using FastColoredTextBoxNS;
using System.Diagnostics;
using System.Text;
using System.Windows.Forms.Design;

namespace MbFastColorEdit
{
    public partial class FormMain : Form
    {

        string _appname = "Fast Colored Editor";
        string _currentfile = "";
        bool _modified = false;
        bool _blocklangchange = false;
        Encoding _encfile = Encoding.UTF8;

        public FormMain()
        {
            InitializeComponent();
        }
        public FormMain(string[] args)
        {
            InitializeComponent();

            // Open file is passed as an argument
            if (args.Length > 0)
            {
                if (File.Exists(args[0]))
                {
                    LoadFile(args[0]);
                }

            }

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

                // If modified, see if we want to open new file and lose changes ?
                if (_modified)
                {
                    // Bail out if  confirmation = No
                    if (MessageBox.Show(String.Format("Do you want to open a new file without saving changes?"), "Open File", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    {
                        return;
                    }
                }

                // SHow open file dialog and open file 
                var f1 = new OpenFileDialog();
                f1.Title = "Open File";
                f1.Multiselect = false;
                f1.Filter = "All files (*.*)|*.*";
                _modified = false;

                // Load file if OK selected
                if (f1.ShowDialog() == DialogResult.OK)
                {
                    LoadFile(f1.FileName);
                }

            }
            catch (Exception ex)
            {
                ShowInfoMessage(ex.Message, _appname);
            }

        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

                // If modified, see if we want to open new file and lose changes ?
                if (_modified)
                {
                    // Bail out if  confirmation = No
                    if (MessageBox.Show(String.Format("Do you want to start a new file without saving changes?"), "Open File", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    {
                        return;
                    }
                }

                // Set up for new file
                fastText1.Text = "";
                this.Text = _appname + " - New File";
                _currentfile = "";
                _modified = false;
                toolStripStatusLabel1.Text = "Unmodified";
                toolStripStatusLabel1.ForeColor = Color.DarkGreen;
            }
            catch (Exception ex)
            {
                ShowInfoMessage(ex.Message, _appname);
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // If modified, see if we want to open new file and lose changes ?
            if (_modified)
            {
                // Bail out if  confirmation = No
                if (MessageBox.Show(String.Format("Do you want to save file changes?"), "Save File", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    return;
                }
            }

            SaveFile();
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileAs();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Application.Exit();
            }
            catch (Exception ex)
            {
            }
        }

        /// <summary>
        /// Display messagebox with OK and Info Flags
        /// </summary>
        /// <param name="message"></param>
        /// <param name="title"></param>
        private void ShowInfoMessage(string message, string title)
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void fastText1_TextChanged(object sender, FastColoredTextBoxNS.TextChangedEventArgs e)
        {
            try
            {
                toolStripStatusLabel1.Text = "Modified";
                toolStripStatusLabel1.ForeColor = Color.DarkRed;
                _modified = true;
            }
            catch (Exception ex)
            {

            }
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            // Set title
            this.Text = Properties.Settings.Default.AppTitle;
            _appname = Properties.Settings.Default.AppTitle;

            // Reset modified flag before doing anything
            _modified = false;

            // Start new file on program open if no file name passed
            // on the command line 
            if (_currentfile.Trim() == "")
            {
                newToolStripMenuItem.PerformClick();
            }

        }

        /// <summary>
        /// Open selected file
        /// </summary>
        /// <param name="filename">File name</param>
        /// <returns></returns>
        public bool OpenFile(string filename)
        {
            {
                try
                {
                    fastText1.Enabled = false;
                    fastText1.Text = File.ReadAllText(filename);
                    fastText1.ClearSelected(); // Unselect all text
                    this.Text = _appname + " - " + filename;
                    _currentfile = filename;
                    _modified = false;
                    toolStripStatusLabel1.Text = "Unmodified";
                    toolStripStatusLabel1.ForeColor = Color.DarkGreen;
                    return true;

                }
                catch (Exception ex)
                {
                    ShowInfoMessage(ex.Message, _appname);
                    return false;
                }
                finally
                {
                    fastText1.Enabled = true;

                }

            }

        }

        private void buttonSaveFile_Click(object sender, EventArgs e)
        {

            // If modified, see if we want to open new file and lose changes ?
            if (_modified)
            {
                // Bail out if  confirmation = No
                if (MessageBox.Show(String.Format("Do you want to save file changes?"), "Save File", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    return;
                }

                SaveFile();
            }
            else
            {
                ShowInfoMessage("There are no changes to current file.", "Save File");
            }

        }

        private void buttonFindText_Click(object sender, EventArgs e)
        {
            try
            {
                fastText1.ShowFindDialog();
            }
            catch (Exception ex)
            {
            }

        }

        private void buttonReplaceText_Click(object sender, EventArgs e)
        {
            try
            {
                fastText1.ShowReplaceDialog();
            }
            catch (Exception ex)
            {
            }
        }

        private void buttonIncreaseFontSize_Click(object sender, EventArgs e)
        {
            try
            {
                fastText1.ChangeFontSize(1);
            }
            catch (Exception ex)
            {
            }
        }

        private void buttonDecreaseFontSize_Click(object sender, EventArgs e)
        {
            try
            {
                fastText1.ChangeFontSize(-1);
            }
            catch (Exception ex)
            {
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // If modified, see if we want to close and lose changes ?
            if (_modified)
            {
                // Bail out if  confirmation = No
                if (MessageBox.Show(String.Format("Do you want to close editor without saving changes?"), "Close Editor", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    e.Cancel = true;
                    return;
                }
            }

        }

        // <summary>
        /// Determines a text file's encoding by analyzing its byte order mark (BOM).
        /// Defaults to ASCII when detection of the text file's endianness fails.
        /// https://stackoverflow.com/questions/3825390/effective-way-to-find-any-files-encoding
        /// </summary>
        /// <param name="filename">The text file to analyze.</param>
        /// <returns>The detected encoding.</returns>
        public static Encoding GetEncoding(string filename)
        {
            // Read the BOM
            var bom = new byte[4];
            using (var file = new FileStream(filename, FileMode.Open, FileAccess.Read))
            {
                file.Read(bom, 0, 4);
            }

            // Analyze the BOM
            if (bom[0] == 0x2b && bom[1] == 0x2f && bom[2] == 0x76) return Encoding.UTF7;
            if (bom[0] == 0xef && bom[1] == 0xbb && bom[2] == 0xbf) return Encoding.UTF8;
            if (bom[0] == 0xff && bom[1] == 0xfe && bom[2] == 0 && bom[3] == 0) return Encoding.UTF32; //UTF-32LE
            if (bom[0] == 0xff && bom[1] == 0xfe) return Encoding.Unicode; //UTF-16LE
            if (bom[0] == 0xfe && bom[1] == 0xff) return Encoding.BigEndianUnicode; //UTF-16BE
            if (bom[0] == 0 && bom[1] == 0 && bom[2] == 0xfe && bom[3] == 0xff) return new UTF32Encoding(true, true);  //UTF-32BE

            // We actually have no idea what the encoding is if we reach this point, so
            // you may wish to return null instead of defaulting to ASCII
            return Encoding.ASCII;
        }

        public bool LoadFile(string filename, bool breadonly = false)
        {
            try
            {

                // Block combobox change event from triggering
                // a language change because we just did it on file/open
                _blocklangchange = true;

                // Set XML as language
                if (filename.ToLower().Contains(".xml"))
                {
                    fastText1.Language = FastColoredTextBoxNS.Language.XML;
                    comboLanguage.Text = "XML";
                }
                else if (filename.ToLower().Contains(".vb"))
                {
                    fastText1.Language = FastColoredTextBoxNS.Language.VB;
                    comboLanguage.Text = "VB";
                }
                else if (filename.ToLower().Contains(".sql"))
                {
                    fastText1.Language = FastColoredTextBoxNS.Language.SQL;
                    comboLanguage.Text = "VB";
                }
                else if (filename.ToLower().Contains(".json"))
                {
                    fastText1.Language = FastColoredTextBoxNS.Language.JSON;
                    comboLanguage.Text = "JSON";
                }
                else if (filename.ToLower().Contains(".js"))
                {
                    fastText1.Language = FastColoredTextBoxNS.Language.JS;
                    comboLanguage.Text = "JS";
                }
                else if (filename.ToLower().Contains(".cs"))
                {
                    fastText1.Language = FastColoredTextBoxNS.Language.CSharp;
                    comboLanguage.Text = "CS";
                }
                else if (filename.ToLower().Contains(".html"))
                {
                    fastText1.Language = FastColoredTextBoxNS.Language.HTML;
                    comboLanguage.Text = "HTML";
                }
                else if (filename.ToLower().Contains(".htm"))
                {
                    fastText1.Language = FastColoredTextBoxNS.Language.HTML;
                    comboLanguage.Text = "HTML";
                }
                else if (filename.ToLower().Contains(".php"))
                {
                    fastText1.Language = FastColoredTextBoxNS.Language.PHP;
                    comboLanguage.Text = "PHP";
                }
                else if (filename.ToLower().Contains(".lua"))
                {
                    fastText1.Language = FastColoredTextBoxNS.Language.Lua;
                    comboLanguage.Text = "LUA";
                }
                else
                {
                    fastText1.Language = FastColoredTextBoxNS.Language.Custom;
                    comboLanguage.Text = "Custom";
                }

                // Set font size
                //fastText1.ChangeFontSize(9);

                // Get file encoding
                _encfile = GetEncoding(filename);

                // Attempt to open file now     
                fastText1.OpenFile(filename, _encfile);

                this.Text = filename; // Set title
                _currentfile = filename; // Save file name for local use
                _modified = false;
                if (breadonly)
                {
                    fastText1.ReadOnly = true;
                    buttonSaveLocalSourceMemberFile.Enabled = false;

                    toolStripStatusLabel1.Text = "Read Only";
                    toolStripStatusLabel1.ForeColor = Color.DarkRed;
                    fastText1.BackColor = Color.FromName("WhiteSmoke");
                    this.Text = _appname + " - " + filename;
                }
                else
                {
                    toolStripStatusLabel1.Text = "Unmodified";
                    toolStripStatusLabel1.ForeColor = Color.DarkGreen;
                    fastText1.BackColor = Color.FromName("White");
                    this.Text = _appname + " - " + filename;
                }

                return true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally {
                _blocklangchange = false;
            }

        }

        /// <summary>
        /// Save current file now
        /// </summary>
        /// <returns></returns>
        public bool SaveFile()
        {
            try
            {

                if (File.Exists(_currentfile))
                {
                    // Save the file now
                    fastText1.SaveToFile(_currentfile, _encfile);
                    toolStripStatusLabel1.Text = "Saved";
                    toolStripStatusLabel1.ForeColor = Color.DarkBlue;
                    _modified = false;  // Reset modified flag on save
                    return true;

                }
                else
                {

                    var f1 = new SaveFileDialog();
                    f1.Title = "Save File";
                    f1.Filter = "All files (*.*)|*.*";

                    if (f1.ShowDialog() == DialogResult.OK)
                    {
                        // Save the file now
                        _currentfile = f1.FileName;
                        fastText1.SaveToFile(_currentfile, _encfile);
                        toolStripStatusLabel1.Text = "Saved";
                        this.Text = _appname + " - " + _currentfile;
                        toolStripStatusLabel1.ForeColor = Color.DarkBlue;
                        _modified = false;  // Reset modified flag on save
                        return true;
                    }
                    else
                    {
                        ShowInfoMessage("File save was cancelled.", _appname);
                        return false;
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        /// <summary>
        /// Save File As 
        /// </summary>
        /// <returns></returns>
        public bool SaveFileAs()
        {
            try
            {

                var f1 = new SaveFileDialog();
                f1.Title = "Save File";
                f1.Filter = "All files (*.*)|*.*";
                f1.FileName = _currentfile;

                if (f1.ShowDialog() == DialogResult.OK)
                {
                    // Save the file now
                    _currentfile = f1.FileName;
                    fastText1.SaveToFile(_currentfile, _encfile);
                    toolStripStatusLabel1.Text = "Saved";
                    this.Text = _appname + " - " + _currentfile;
                    toolStripStatusLabel1.ForeColor = Color.DarkBlue;
                    _modified = false;  // Reset modified flag on save
                    return true;
                }
                else
                {
                    ShowInfoMessage("File save was cancelled.", _appname);
                    return false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        bool CloseFile()
        {
            try
            {

                fastText1.Text = "";
                this.Text = _appname;
                _currentfile = "";
                _modified = false;
                toolStripStatusLabel1.Text = "Unmodified";
                toolStripStatusLabel1.ForeColor = Color.DarkGreen;
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }


        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {

            // If modified, see if we want to close and lose changes ?
            if (_modified)
            {
                // Bail out if  confirmation = No
                if (MessageBox.Show(String.Format("Do you want to close file without saving changes?"), "Close File", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    return;
                }
            }

            CloseFile();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

                fastText1.Undo();

            }
            catch (Exception ex)
            {

            }

        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

                fastText1.Redo();

            }
            catch (Exception ex)
            {

            }
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

                fastText1.Cut();

            }
            catch (Exception ex)
            {

            }
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

                fastText1.Copy();

            }
            catch (Exception ex)
            {

            }
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

                fastText1.Paste();
            }
            catch (Exception ex)
            {

            }
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

                fastText1.SelectAll();

            }
            catch (Exception ex)
            {

            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int lcTraceId = 0;
            //AssemblyName version = null;

            try
            {

                lcTraceId = 100;
                // This only works when not compiling to self contained exe
                //var versionInfo = FileVersionInfo.GetVersionInfo(Assembly.GetExecutingAssembly().Location);
                // This should get the current exe whether self contained or not
                var versionInfo = FileVersionInfo.GetVersionInfo(System.IO.Path.GetFullPath(Process.GetCurrentProcess().MainModule.FileName));

                //version = Assembly.GetEntryAssembly().GetName();

                lcTraceId = 200;
                //var productName = versionInfo.ProductName;
                var productName = _appname;
                lcTraceId = 400;
                var companyName = versionInfo.CompanyName;
                lcTraceId = 500;
                var copyRight = versionInfo.LegalCopyright;
                lcTraceId = 600;
                var message = productName + "\r\nVersion " + versionInfo.ProductVersion + "\r\n" + copyRight + "\r\n" + "http://www.mobigogo.net";
                MessageBox.Show(message, "About " + productName, MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                // For testing
                MessageBox.Show(ex.Message + "TraceID:" + Convert.ToString(lcTraceId), "About", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void buttonNewFile_Click(object sender, EventArgs e)
        {
            newToolStripMenuItem.PerformClick();
        }

        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            openToolStripMenuItem.PerformClick();
        }

        private void buttonCloseFile_Click(object sender, EventArgs e)
        {
            closeToolStripMenuItem.PerformClick();
        }

        private void comboLanguage_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboLanguage_SelectedValueChanged(object sender, EventArgs e)
        {

            // Set Editor Language based on language setting
            SetLanguage();

        }

        private void SetLanguage()
        {

            // If block language change = false, set new language
            // Used to block a potentially cascading change event on file/open
            if (_blocklangchange == false)
            {
                // Set languages on text change
                if (comboLanguage.Text.Trim() == "XML")
                {
                    fastText1.Language = FastColoredTextBoxNS.Language.XML;
                }
                else if (comboLanguage.Text.Trim() == "VB")
                {
                    fastText1.Language = FastColoredTextBoxNS.Language.VB;
                }
                else if (comboLanguage.Text.Trim() == "SQL")
                {
                    fastText1.Language = FastColoredTextBoxNS.Language.SQL;
                }
                else if (comboLanguage.Text.Trim() == "JSON")
                {
                    fastText1.Language = FastColoredTextBoxNS.Language.JSON;
                }
                else if (comboLanguage.Text.Trim() == "JS")
                {
                    fastText1.Language = FastColoredTextBoxNS.Language.JS;
                }
                else if (comboLanguage.Text.Trim() == "CS")
                {
                    fastText1.Language = FastColoredTextBoxNS.Language.CSharp;
                }
                else if (comboLanguage.Text.Trim() == "HTML")
                {
                    fastText1.Language = FastColoredTextBoxNS.Language.HTML;
                }
                else if (comboLanguage.Text.Trim() == "PHP")
                {
                    fastText1.Language = FastColoredTextBoxNS.Language.PHP;
                }
                else if (comboLanguage.Text.Trim() == "LUA")
                {
                    fastText1.Language = FastColoredTextBoxNS.Language.Lua;
                }
                else
                {
                    fastText1.Language = FastColoredTextBoxNS.Language.Custom;
                }

                // When laguage changes, repaint with new syntax.
                // Only way I found was to save and re-load the text 
                // to a string variable.
                var textdata = fastText1.Text;
                fastText1.Text = "";
                fastText1.Text = textdata;

            }
        }

    }
}

