using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NBitcoin;

namespace dotnet_wallet
{
    public partial class dotnetwallet : Form
    {
        public dotnetwallet()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var privatekey = new Key();
            var btcprivatekey = privatekey.GetWif(Network.Main).ToString();
            lblPrivateKey.Text = btcprivatekey;

            // Generate a public key from our private key
            var btcpublickey = privatekey.PubKey.ToString();

            // Generate BTC address from public key
            var btcadress1 = privatekey.GetAddress(ScriptPubKeyType.Segwit, Network.Main);
            lblAddress.Text = btcadress1.ToString(); 

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lblAddress_Click(object sender, EventArgs e)
        {

        }

        private void btnGenerateSeed_Click_1(object sender, EventArgs e)
        {
            var mnemonic = new Mnemonic(Wordlist.English, WordCount.Twelve);
            lblMnemonic.Text = mnemonic.ToString();

            var hdroot = mnemonic.DeriveExtKey();
            var pkey = hdroot.Derive(new KeyPath("m/84'/0'/0'/0/0'"));
            var address = pkey.PrivateKey.GetAddress(ScriptPubKeyType.Segwit, Network.Main);
            lblMnemonicAddress.Text = address.ToString();
        }
    }
}
