using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Booked
{
    public partial class PrivacyPolicy : Form
    {
        public PrivacyPolicy()
        {
            InitializeComponent();
             richTextBox1.ReadOnly = true;
            richTextBox1.Text = "Privacy Policy of Online Bookstore +\n+ 1. Introduction +\n+ 1.1. This Privacy Policy outlines how Read me! store collects, uses, discloses, and protects personal information obtained from users of our online bookstore platform. +\n+ 2. Collection of Personal Information +\n+ 2.1. We collect personal information such as name, address, email address, and payment details when you register on our application, place an order, or interact with our services. +\n+ 2.2. We may also collect non-personal information such as browser type, language preference, referring app, and the date and time of each visitor request to improve our services. +\n+ 3. Use of Personal Information +\n+ 3.1. Personal information is used to process personalized user experience, improve our application, and send periodic emails regarding orders and other products and services. +\n+ 3.2. Non-personal information may be used for marketing, advertising, or other uses. +\n+ 4. Protection of Information +\n+ 4.1. We implement a variety of security measures to maintain the safety of your personal information when you place an order or access your personal information. +\n+ 4.2. Your personal information is contained behind secured networks and is only accessible by a limited number of persons who have special access rights to such systems and are required to keep the information confidential. +\n+ 5. Disclosure of Information +\n+ 5.1. We do not sell, trade, or otherwise transfer your personal information to outside parties unless we provide users with advance notice. +\n+ 5.2. This does not include trusted third parties who assist us in operating our application, conducting our business, or servicing you, so long as those parties agree to keep this information confidential. +\n+ 6. Consent +\n+ 6.1. By using our app, you consent to our privacy policy. +\n+ MIHLALI SILINGA +\n+ NOLWAZI MBUNDU +\n+ SIMNIKIWE SAWUTANA +\n+ WILLMUR RHODE +\n+ 08 JULY 2024 +\n+ 7.Changes to our Privacy Policy +\n+ 7.1. If we decide to change our privacy policy, we will post those changes on this page. +\n+ 8. Contact Information +\n+ 8.1. If there are any questions regarding this privacy policy, you may contact us using the information below: +\n+ Read me! llubanzi14@gmail.com 0656606320 +\n+ ";

        }

        private void Submitbtn_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                MessageBox.Show("Thank you for accepting the PrivacyPolicy. Response will be submitted!");
                this.Hide();
                Form1 frm = new Form1();
                frm.Show();
            }
            else
            {
                MessageBox.Show("Please read the Privacy Policy before accepting!");
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
