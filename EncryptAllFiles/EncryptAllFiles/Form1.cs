using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using Crypto;
using StringExtensions;

namespace EncryptAllFiles
{
    public partial class Form1 : Form
    {
        //contains all ASCII characters
        byte[] alpha;
        //a Matrix in 2D. Consists out of all characters from alpha with row i beginning with value in index i from alpha.
        byte[,] matrix;
        //Path used to write encrypted files to
        const string EncrFolder = @"c:\Encrypt\";
        //Path used to write decrypted files to
        const string DecrFolder = @"c:\Decrypt\";
        //Path used to write hashed values to
        const string Hashdirectory = @"C:\HashedValues\";
        //Path used to create a textfile which hashed passwords are written to
        const string HashPath = @"C:\HashedValues\HashedPasswords.txt";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblTime.Text = "";
            lblTime.BackColor = Color.Transparent;
            lblHeading1.BackColor = Color.Transparent;
            lblHeading2.BackColor = Color.Transparent;
            label1.BackColor = Color.Transparent;
            rbtnDecrypt.BackColor = Color.Transparent;
            rbtnEncrypt.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
            label3.BackColor = Color.Transparent;
            timer1.Enabled = true;
            //Creates directories for storing encrypted and decrypted files
            Directory.CreateDirectory(EncrFolder);
            Directory.CreateDirectory(DecrFolder);
            Directory.CreateDirectory(Hashdirectory);
            //Creates the text file to store salted passwords
            File.Create(HashPath);
            //Code for dislaying messages when hovering over interface objects
            toolTipBrowse.SetToolTip(btnBrowse,"Browse for a file to encrypt/decrypt");
            toolTipEncrypt.SetToolTip(rbtnEncrypt, "Click to allow encryption of a file");
            toolTipDecrypt.SetToolTip(rbtnDecrypt, "Click to allow decryption of a file");
            toolTipPassword.SetToolTip(txtPassword, "Enter a key of any length");
            toolTipStart.SetToolTip(btnStart, "Encrypt/Decrypt selected file");
            toolTipViewEncrypted.SetToolTip(btnViewEncrypted, "The content might take a while to load...");
            txtPath.BackColor = this.BackColor;
            txtPassword.BackColor = Color.White;
            txtPassword.PasswordChar = '*';
            txtPass.PasswordChar = '*';
            rbtnEncrypt.Checked = true;
            // init alpha and matrix
            alpha = new byte[256];
            //there are 256 ASCII characters
            for (int i = 0; i < 256; i++)
            {
                alpha[i] = Convert.ToByte(i);
            }
            matrix = new byte[256, 256];
            //Give the matrix new values used for encryption
            for (int i = 0; i < 256; i++)
            {
                for (int j = 0; j < 256; j++)
                {
                    matrix[i, j] = alpha[(i + j) % 256];
                }
            }
        }

        //returns the salted password
        public string CreatePasswordHash(string pwd)
        {
            return CreatePasswordHash(pwd, CreateSalt());
        }

        //Allows the password to be salted
        private byte[] GetHash(string password)
        {
            SHA384 sha = new SHA384CryptoServiceProvider();
            return sha.ComputeHash(Encoding.UTF8.GetBytes(password));
        }

        //appends the salted characters into one full length string
        private string GetHashString(string password)
        {
            StringBuilder sb = new StringBuilder();
            foreach (byte b in GetHash(password))
            {
                sb.Append(b.ToString("X2"));
            }
            return sb.ToString();
        }

        //Creates salted version of password
        public string CreatePasswordHash(string password, string salt)
        {
            string saltAndpassword = String.Concat(password, salt);
            string hashedpassword = GetHashString(saltAndpassword);
            var saltPosition = 5;
            hashedpassword = hashedpassword.Insert(saltPosition, salt);
            return hashedpassword;
        }
        
        //Validates the password
        public bool Validate(string password, string passwordHash)
        {
            var saltPosition = 5;
            var saltSize = 10;
            var salt = passwordHash.Substring(saltPosition, saltSize);
            var hashedPassword = CreatePasswordHash(password, salt);
            return hashedPassword == passwordHash;
        }
        
        //Converts the salted password to uppercase
        private string CreateSalt()
        {
            RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
            byte[] buff = new byte[20];
            rng.GetBytes(buff);
            var saltSize = 10;
            string salt = Convert.ToBase64String(buff);
            if (salt.Length > saltSize)
            {
                salt = salt.Substring(0, saltSize);
                return salt.ToUpper();
            }
            var saltChar = '^';
            salt = salt.PadRight(saltSize, saltChar);
            return salt.ToUpper();
        }

        private void SaveFiles(string directory,byte[] rs)
        {
            // Save result to new file with the same extension
            String fileExt = Path.GetExtension(txtPath.Text);
            SaveFileDialog sd = new SaveFileDialog();
            sd.Filter = "Files (*" + fileExt + ") | *" + fileExt;
            sd.InitialDirectory = directory;
            if (sd.ShowDialog() == DialogResult.OK)
            {
                //Writes all content int the encrypted/decrypted file to a new file
                File.WriteAllBytes(sd.FileName, rs);
                if (rbtnEncrypt.Checked)
                {
                    //Executes the asynchronous task
                    Task hashed = WriteHash(HashPath, CreatePasswordHash(txtPassword.Text));
                }
            }
        }

        private void Browse()
        {
            this.Icon = null;
            OpenFileDialog open = new OpenFileDialog();
            open.Title = "SELECT FILE";
            //Doesn't allow multiple files to be selected at once
            open.Multiselect = false;
            if (open.ShowDialog() == DialogResult.OK)
            {
                txtPath.Text = open.FileName;
            }
            //In order to change the icon for a form or dialog box, you need to download an .ico file and import it to your solution
            this.Icon = new Icon("Paomedia-Small-N-Flat-Lock.ico");
        }

        //Allows you to browse for a file to encrypt/decrypt
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            Browse();
        }

        //Checks whether the selected file needs to be encrypted
        private void rbtnEncrypt_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnEncrypt.Checked)
            {
                rbtnDecrypt.Checked = false;
            }
        }

        //Checks whether the selected file needs to be decrypted
        private void rbtnDecrypt_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnDecrypt.Checked)
            {
                rbtnEncrypt.Checked = false;
            }
        }

        //Asynchronous task (process) used to write the salted password to a textfile
        private async Task WriteHash(string path, string password)
        {
            try
            {
                using (StreamWriter outputFile = new StreamWriter(path, true))
                {
                    outputFile.WriteLine(password);
                }
                MessageBox.Show("Hash written to text file", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Failed to write hash to file", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Encrypts or Decrypts the selected file
        private void btnStart_Click(object sender, EventArgs e)
        {
            //Check if chosen file exists
            if (!File.Exists(txtPath.Text))
            {
                MessageBox.Show("File does not exist","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            //Checks whether a password is entered to encrypt/decrypt a file
            if (String.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Password empty. Please enter your password", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Get file content and password for encryption/decryption
            try
            {
                //read all contents from files in bytes
                byte[] fileContent = File.ReadAllBytes(txtPath.Text);
                //encode the key entered by user
                byte[] passwordTmp = Encoding.ASCII.GetBytes(txtPassword.Text);
                //Specify new key with a specified
                byte[] keys = new byte[fileContent.Length];
                for (int i = 0; i < fileContent.Length; i++)
                {
                    //Generate new values for the key
                    keys[i] = passwordTmp[i % passwordTmp.Length];
                }
                // Encrypt
                byte[] result = new byte[fileContent.Length];
                if (rbtnEncrypt.Checked)
                {
                    //Encodes all content in the file
                    for (int i = 0; i < fileContent.Length; i++)
                    {
                        //get byte value character by character
                        byte value = fileContent[i];
                        byte key = keys[i];
                        int valueIndex = -1;
                        int keyIndex = -1;
                        for (int j = 0; j < 256; j++)
                            if (alpha[j] == value)
                            {
                                valueIndex = j;
                                break;
                            }
                        for (int j = 0; j < 256; j++)
                            if (alpha[j] == key)
                            {
                                keyIndex = j;
                                break;
                            }
                        result[i] = matrix[keyIndex, valueIndex];
                    }
                    //Writes the encoded content to a new file
                    SaveFiles(EncrFolder, result);
                }
                // Decrypt
                else
                {
                    //Decodes all content in the file
                    for (int i = 0; i < fileContent.Length; i++)
                    {
                        //get byte value character by character
                        byte value = fileContent[i];
                        byte key = keys[i];
                        int valueIndex = -1;
                        int keyIndex = -1;
                        for (int j = 0; j < 256; j++)
                            if (alpha[j] == key)
                            {
                                keyIndex = j;
                                break;
                            }
                        for (int j = 0; j < 256; j++)
                            if (matrix[keyIndex, j] == value)
                            {
                                valueIndex = j;
                                break;
                            }
                        result[i] = alpha[valueIndex];
                    }
                    //Writes the decoded content to a new file
                    SaveFiles(DecrFolder, result);
                }
            }
            catch
            {
                MessageBox.Show("File is in use. Close other program using this file and try again.","ERROR",MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                return;
            }
        }

        //DCS 
        // Encrypt the plaintext file
        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            // Encrypt the file.
            Task hashed = WriteHash(HashPath, CreatePasswordHash(txtPass.Text));
            String fileExt = Path.GetExtension(txtPlainPath.Text);
            SaveFileDialog sd = new SaveFileDialog();
            sd.Filter = "Files (*" + fileExt + ") | *" + fileExt;
            sd.InitialDirectory = EncrFolder;
            if (sd.ShowDialog() == DialogResult.OK)
            {
                txtEncryptPath.Text = sd.FileName;
                //Writes all content int the encrypted/decrypted file to a new file
                CryptoStuff.EncryptFile(txtPass.Text, txtPlainPath.Text, txtEncryptPath.Text);
                // Display the result.
                if (sd.FileName.Substring(Math.Max(0, sd.FileName.Length - 3)) == "zip" || 
                sd.FileName.Substring(Math.Max(0, sd.FileName.Length - 3)) == "rar")
                {
                    txtEncrypt.Text = ".zip or .rar content cannot be displayed here, but we did save your encrypted content to the selected " +
                    "directory";
                }
                else
                {
                    txtEncrypt.Text = File.ReadAllBytes(txtEncryptPath.Text).ToHex(' ');
                }
            }
        }
        // Decrypt the ciphertext file.
        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            String fileExt = Path.GetExtension(txtPlainPath.Text);
            SaveFileDialog sd = new SaveFileDialog();
            sd.Filter = "Files (*" + fileExt + ") | *" + fileExt;
            sd.InitialDirectory = DecrFolder;
            if (sd.ShowDialog() == DialogResult.OK)
            {
                txtDecryptPath.Text = sd.FileName;
                // Decrypt the file.
                CryptoStuff.DecryptFile(txtPass.Text, txtEncryptPath.Text, txtDecryptPath.Text);
                // Display the result.
                txtDecrypt.Text = File.ReadAllText(txtDecryptPath.Text);
            }
        }

        private void btnBrowseContent_Click(object sender, EventArgs e)
        {
            this.Icon = null;
            OpenFileDialog open = new OpenFileDialog();
            open.Title = "SELECT FILE";
            //Doesn't allow multiple files to be selected at once
            open.Multiselect = false;
            if (open.ShowDialog() == DialogResult.OK)
            {
                txtPlainPath.Text = open.FileName;
                txtPlain.Text = File.ReadAllText(txtPlainPath.Text);
            }
            //In order to change the icon for a form or dialog box, you need to download an .ico file and import it to your solution
            this.Icon = new Icon("Paomedia-Small-N-Flat-Lock.ico");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("dd-MMM-yyyy" + "\n" + "hh:mm:ss tt");
        }

        private void lblTime_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Are you sure you want to exit?", "DIALOG", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (dialog == DialogResult.Yes )
            {
                Application.Exit();
            }
        }

        private void btnExit_MouseHover(object sender, EventArgs e)
        {
            btnExit.BackColor = Color.Red;
        }

        private void btnExit_MouseLeave(object sender, EventArgs e)
        {
            btnExit.BackColor = Color.FromArgb(128, 255, 128);
        }
    }
}
