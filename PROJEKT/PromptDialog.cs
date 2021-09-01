using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJEKT
{
    /// <summary>
    /// klasa obslugująca okienko PromptDialog
    /// </summary>
    public partial class PromptDialog : Form
    {

        /// <summary>
        /// obsługa wpisanego tekstu
        /// </summary>
        public string Response
        {
            get { return this.textBoxResponse.Text; }
        }


        public PromptDialog()
        {
            InitializeComponent();
        }


        /// <summary>
        /// załadowanie wyskakującego okienka
        /// </summary>
        private void PromptDialog_Load(object sender, EventArgs e)
        {

        }
    }
}