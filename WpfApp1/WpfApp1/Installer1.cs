using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration.Install;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace WpfApp1
{
    [RunInstaller(true)]
    public partial class Installer1 : System.Configuration.Install.Installer
    {
        public Installer1()
        {
            InitializeComponent();

            this.BeforeInstall += InstallerClass_BeforeInstall;
        }

        private void InstallerClass_BeforeInstall(object sender, InstallEventArgs e)
        {
            MessageBox.Show("Test");
        }

        public override void Install(IDictionary stateSaver)
        {
            MessageBox.Show("Install");
            base.Install(stateSaver); 
        }
    }
}
