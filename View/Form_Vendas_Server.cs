using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;

namespace Vendas.Server.View
{
    public partial class Form_Vendas_Server : Form
    {
        private int exitControl;
        public Form_Vendas_Server()
        {
            InitializeComponent();
        }

        private void notifyIcon_DoubleClick(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void radioButton_serverOnline_CheckedChanged(object sender, EventArgs e)
        {
            pb_serverStatus.Image = global::Vendas.View.Properties.Resources.Network_Alt;

            try
            {
                TcpChannel myIp = new TcpChannel(8080);
                //TcpServerChannel myIp = new TcpServerChannel("192.168.2.100", 8080);

                ChannelServices.RegisterChannel(myIp, false);

                Type commonInterfaceType = Type.GetType("Vendas.View.Services");

                var teste = Type.GetType("Vendas.Server.View.Services");

                RemotingConfiguration.RegisterWellKnownServiceType(commonInterfaceType, "Services", WellKnownObjectMode.SingleCall);

                Hide();

                notifyIcon_ServerApp.ShowBalloonTip(100, "Information", "Servidor ativo.", ToolTipIcon.Info);
            }
            catch (Exception ef) { MessageBox.Show("Erro: " + ef.Message); }
        }

        private void radioButton_serverOffline_CheckedChanged(object sender, EventArgs e)
        {
            pb_serverStatus.Image = global::Vendas.View.Properties.Resources.Network_Offline_Alt;
        }

        private void radioButton_serverOffline_Click(object sender, EventArgs e)
        {
            if (exitControl > 0)
            {
                pb_serverStatus.Image = global::Vendas.View.Properties.Resources.Network_Offline_Alt;

                DialogResult result = MessageBox.Show("Deseja encerrar a aplicação do servidor?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result.Equals(DialogResult.No))
                    return;

                Application.Exit();
            }
            exitControl++;
        }

        private void notifyIcon_ServerApp_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
        }

    }
}
