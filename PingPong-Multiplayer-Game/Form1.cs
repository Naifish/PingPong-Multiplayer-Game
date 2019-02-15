using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Net.Sockets;

namespace PingPong_Multiplayer_Game
{
    public partial class Form1 : Form
    {

        PingPong pnp = new PingPong();
        IPAddress servr_ip;


        TcpListener tl;
        TcpClient connected_client, c;
        public bool sConnected;

        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true;
            InitializeComponent();
            pnp.ping_pong(gameover_lbl, p1_points_lbl, p2_points_lbl, playground, racket, racket2, ball, ball2, timer1);
            this.TopMost = true;
        }

        int racket_left2;
        public int getready = 3;
        public bool play_single = false;
        public bool play_multi = false;
        public bool play_online = false;
        public bool play_easy = false;
        public bool play_hard = false;
        public bool play_expert = false;
        public bool playAs_player = false;
        public bool playAs_server = false;
        public bool isPlayerConnected_to_server = false;
        public bool isMeConnected = false;
        public bool volume = true;
        public bool isGameEnd = false;
        public string Result = "";

        System.Media.SoundPlayer sp = new System.Media.SoundPlayer(@"D:\software\pingpongmusic.wav");

        private void backtodificulty_pb_Click(object sender, EventArgs e)
        {
            easy_btn.Visible = true;
            hard_btn.Visible = true;
            expert_btn.Visible = true;

            backtoplaymod_pb.Visible = true;
            backtodificulty_pb.Visible = false;

            creatserver_btn.Visible = false;
            ipaddress_lbl.Visible = false;
            ip_tb.Visible = false;
            joinplayer_btn.Visible = false;
            waitingforplyr_lbl.Visible = false;
        }

        private void backtomain_pb_Click(object sender, EventArgs e)
        {
            startgame_btn.Visible = true;
            howtoply_btn.Visible = true;
            exitgame_btn.Visible = true;
            exit_pb.Visible = false;

            singleplyr_btn.Visible = false;
            multiplyr_btn.Visible = false;
            onlineply_btn.Visible = false;

            backtomain_pb.Visible = false;
            howtoplaydesc_lbl.Visible = false;
        }

        private void backtoplaymod_pb_Click(object sender, EventArgs e)
        {
            easy_btn.Visible = false;
            hard_btn.Visible = false;
            expert_btn.Visible = false;

            singleplyr_btn.Visible = true;
            multiplyr_btn.Visible = true;
            onlineply_btn.Visible = true;

            backtomain_pb.Visible = true;
            backtoplaymod_pb.Visible = false;
        }

        private void creatserver_btn_Click(object sender, EventArgs e)
        {
            {

                playAs_player = false;
                joinplayer_btn.Enabled = false;
                playAs_server = true;

                //get ip of the server machine
                IPHostEntry host;
                host = Dns.GetHostEntry(Dns.GetHostName());
                foreach (IPAddress ip in host.AddressList)
                {
                    if (ip.AddressFamily == AddressFamily.InterNetwork)
                    {
                        ip_tb.Text = ip.ToString();
                        servr_ip = ip;
                    }
                }

                IPEndPoint ipe = new IPEndPoint(servr_ip, 8080);

                tl = new TcpListener(ipe);

                tl.Start();
                waitingforplyr_lbl.Visible = true;

                try
                {
                    //connected_client = tl.AcceptTcpClient();
                    tl.BeginAcceptTcpClient(new AsyncCallback(AcceptClient), tl);


                }
                catch (SocketException se)
                {
                    MessageBox.Show(se.Message);

                }
            }
        }

        private void easy_btn_Click(object sender, EventArgs e)
        {
            timer2.Start();  //starting get ready label
            Cursor.Hide();

            play_easy = true;
            play_hard = false;
            play_expert = false;

            if (play_online == true)
            {
                Cursor.Show();

                easy_btn.Visible = false;
                hard_btn.Visible = false;
                expert_btn.Visible = false;

                backtoplaymod_pb.Visible = false;
                backtodificulty_pb.Visible = true;

                creatserver_btn.Visible = true;
                ipaddress_lbl.Visible = true;
                ip_tb.Visible = true;
                joinplayer_btn.Visible = true;
            }
            else
            {
                playground.Visible = true;
                racket.Visible = true;
                ball.Visible = true;
                p2_score_lbl.Visible = true;
                p1_points_lbl.Visible = true;
                getready_lbl.Visible = true;

                backtodificulty_pb.Visible = false;
                backtoplaymod_pb.Visible = false;
                easy_btn.Visible = false;
                hard_btn.Visible = false;
                expert_btn.Visible = false;
                options_lbl.Visible = false;
                volume_pb.Visible = false;
                exit_pb.Visible = false;
            }

        }

        private void exit_pb_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void exitgame_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void expert_btn_Click(object sender, EventArgs e)
        {
            {
                Cursor.Hide();

                play_easy = false;
                play_hard = false;
                play_expert = true;

                timer2.Start();  //starting get ready label

                if (play_online == true)
                {
                    Cursor.Show();

                    easy_btn.Visible = false;
                    hard_btn.Visible = false;
                    expert_btn.Visible = false;

                    backtoplaymod_pb.Visible = false;
                    backtodificulty_pb.Visible = true;

                    creatserver_btn.Visible = true;
                    ipaddress_lbl.Visible = true;
                    ip_tb.Visible = true;
                    joinplayer_btn.Visible = true;
                }

                else
                {
                    playground.Visible = true;
                    racket.Visible = true;
                    ball.Visible = true;
                    p2_score_lbl.Visible = true;
                    p1_points_lbl.Visible = true;
                    getready_lbl.Visible = true;

                    backtodificulty_pb.Visible = false;
                    backtoplaymod_pb.Visible = false;
                    easy_btn.Visible = false;
                    hard_btn.Visible = false;
                    expert_btn.Visible = false;
                    options_lbl.Visible = false;
                    volume_pb.Visible = false;
                    exit_pb.Visible = false;
                }
            }
        }

        private void hard_btn_Click(object sender, EventArgs e)
        {
            {
                Cursor.Hide();

                play_easy = false;
                play_hard = true;
                play_expert = false;

                timer2.Start();  //starting get ready label

                if (play_online == true)
                {
                    Cursor.Show();

                    easy_btn.Visible = false;
                    hard_btn.Visible = false;
                    expert_btn.Visible = false;

                    backtoplaymod_pb.Visible = false;
                    backtodificulty_pb.Visible = true;

                    creatserver_btn.Visible = true;
                    ipaddress_lbl.Visible = true;
                    ip_tb.Visible = true;
                    joinplayer_btn.Visible = true;
                }

                else
                {
                    playground.Visible = true;
                    racket.Visible = true;
                    ball.Visible = true;
                    p2_score_lbl.Visible = true;
                    p1_points_lbl.Visible = true;
                    getready_lbl.Visible = true;

                    backtodificulty_pb.Visible = false;
                    backtoplaymod_pb.Visible = false;
                    easy_btn.Visible = false;
                    hard_btn.Visible = false;
                    expert_btn.Visible = false;
                    options_lbl.Visible = false;
                    volume_pb.Visible = false;
                    exit_pb.Visible = false;
                }
            }
        }

        private void howtoply_btn_Click(object sender, EventArgs e)
        {
            backtomain_pb.Visible = true;

            startgame_btn.Visible = false;
            howtoply_btn.Visible = false;
            exitgame_btn.Visible = false;

            howtoplaydesc_lbl.Visible = true;
            exit_pb.Visible = true;
        }

        private void joinplayer_btn_Click(object sender, EventArgs e)
        {
            {
                playAs_server = false;
                creatserver_btn.Enabled = false;
                playAs_player = true;

                IPAddress ip = IPAddress.Parse(ip_tb.Text);
                IPEndPoint ipe = new IPEndPoint(ip, 8080);

                c = new TcpClient();

                try
                {
                    c.Connect(ipe);
                    isMeConnected = true;
                    timer2.Start();

                }
                catch (SocketException)
                {

                    MessageBox.Show("There is no server Created to join. wait for someone to create a server.");
                }
            }
        }

        private void multiplyr_btn_Click(object sender, EventArgs e)
        {
            {
                racket_left2 = racket2.Left;

                play_single = false;
                play_multi = true;
                play_online = false;

                singleplyr_btn.Visible = false;
                multiplyr_btn.Visible = false;
                onlineply_btn.Visible = false;

                easy_btn.Visible = true;
                hard_btn.Visible = true;
                expert_btn.Visible = true;

                backtomain_pb.Visible = false;
                backtoplaymod_pb.Visible = true;
            }
        }

        private void onlineply_btn_Click(object sender, EventArgs e)
        {
            {

                play_single = false;
                play_multi = false;
                play_online = true;

                singleplyr_btn.Visible = false;
                multiplyr_btn.Visible = false;
                onlineply_btn.Visible = false;

                easy_btn.Visible = true;
                hard_btn.Visible = true;
                expert_btn.Visible = true;

                backtomain_pb.Visible = false;
                backtoplaymod_pb.Visible = true;
            }
        }

        private void singleplyr_btn_Click(object sender, EventArgs e)
        {


            play_single = true;
            play_multi = false;
            play_online = false;

            singleplyr_btn.Visible = false;
            multiplyr_btn.Visible = false;
            onlineply_btn.Visible = false;

            easy_btn.Visible = true;
            hard_btn.Visible = true;
            expert_btn.Visible = true;

            backtomain_pb.Visible = false;
            backtoplaymod_pb.Visible = true;
        }

        private void startgame_btn_Click(object sender, EventArgs e)
        {
            singleplyr_btn.Visible = true;
            multiplyr_btn.Visible = true;
            onlineply_btn.Visible = true;
            exit_pb.Visible = true;

            backtomain_pb.Visible = true;

            startgame_btn.Visible = false;
            howtoply_btn.Visible = false;
            exitgame_btn.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //single player easy level
            #region single_easy
            if (play_single == true && play_easy == true)
            {
                p2_score_lbl.Visible = false;
                p2_points_lbl.Visible = false;
                p1_score_lbl.Visible = true;
                p1_points_lbl.Visible = true;

                racket.Width = 300;
                racket.BackgroundImageLayout = ImageLayout.None;
                if (getready == -1)
                {
                    pnp.single_easy_level();
                }
                if (racket.Left <= playground.Left)   ///collusion of racket with boundary
                {
                    racket.Left -= racket.Left;
                }

                if (racket.Right >= playground.Right)   ///collusion of racket with boundary
                {
                    racket.Left = 1040;
                }
            }
            #endregion single_easy

            //single player hard level
            #region single_hard
            else if (play_single == true && play_hard == true)
            {
                p2_score_lbl.Visible = false;
                p2_points_lbl.Visible = false;
                p1_score_lbl.Visible = true;
                p1_points_lbl.Visible = true;

                if (getready == -1)
                {
                    pnp.single_hard_level();
                }
                if (racket.Left <= playground.Left)   ///collusion of racket with boundary
                {
                    racket.Left -= racket.Left;
                }

                if (racket.Right >= playground.Right)   ///collusion of racket with boundary
                {
                    racket.Left = 1040;
                }
            }
            #endregion single_hard

            //single player expert level
            #region single_expert
            else if (play_single == true && play_expert == true)
            {
                p2_score_lbl.Visible = false;
                p2_points_lbl.Visible = false;
                p1_score_lbl.Visible = true;
                p1_points_lbl.Visible = true;

                racket.Width = 300;
                ball2.Visible = true;
                if (getready == -1)
                {
                    pnp.single_expert_level();
                }
                if (racket.Left <= playground.Left)   ///collusion of racket with boundary
                {
                    racket.Left -= racket.Left;
                }

                if (racket.Right >= playground.Right)   ///collusion of racket with boundary
                {
                    racket.Left = 1040;
                }
            }
            #endregion single_expert

            //multi_easy
            #region multi_easy
            else if (play_multi == true && play_easy == true)
            {
                Player1.Visible = true;
                Player2.Visible = true;

                p1_score_lbl.Visible = false;
                p1_points_lbl.Visible = false;
                p2_score_lbl.Visible = false;
                p2_points_lbl.Visible = false;

                racket2.Visible = true;
                racket.Width = 300;
                racket.BackgroundImageLayout = ImageLayout.None;
                racket2.Width = 300;
                racket2.BackgroundImageLayout = ImageLayout.None;

                if (getready == -1)
                {
                    pnp.multi_easy_level(racket_left2);
                }
                if (racket.Left <= playground.Left)   ///collusion of racket with boundary
                {
                    racket.Left -= racket.Left;
                }

                if (racket.Right >= playground.Right)   ///collusion of racket with boundary
                {
                    racket.Left = 1040;
                }
                if (racket2.Left <= playground.Left)   ///collusion of racket2 with boundary
                {
                    racket2.Left -= racket2.Left;
                }

                if (racket2.Right >= playground.Right)   ///collusion of racket2 with boundary
                {
                    racket2.Left = 1040;
                }

            }
            #endregion multi_easy

            //multi_hard
            #region multi_hard
            else if (play_multi == true && play_hard == true)
            {
                Player1.Visible = true;
                Player2.Visible = true;

                p1_score_lbl.Visible = false;
                p1_points_lbl.Visible = false;
                p2_score_lbl.Visible = false;
                p2_points_lbl.Visible = false;

                racket2.Visible = true;

                if (getready == -1)
                {
                    pnp.multi_hard_level(racket_left2);
                }
                if (racket.Left <= playground.Left)   ///collusion of racket with boundary
                {
                    racket.Left -= racket.Left;
                }

                if (racket.Right >= playground.Right)   ///collusion of racket with boundary
                {
                    racket.Left = 1040;
                }
                if (racket2.Left <= playground.Left)   ///collusion of racket2 with boundary
                {
                    racket2.Left -= racket2.Left;
                }

                if (racket2.Right >= playground.Right)   ///collusion of racket2 with boundary
                {
                    racket2.Left = 1040;
                }

            }
            #endregion multi_hard

            //multi_expert
            #region multi_expert
            else if (play_multi == true && play_expert == true)
            {
                Player1.Visible = true;
                Player2.Visible = true;

                p1_score_lbl.Visible = false;
                p1_points_lbl.Visible = false;
                p2_score_lbl.Visible = false;
                p2_points_lbl.Visible = false;

                ball2.Visible = true;
                racket2.Visible = true;
                racket.Width = 300;
                racket.BackgroundImageLayout = ImageLayout.None;
                racket2.Width = 300;
                racket2.BackgroundImageLayout = ImageLayout.None;

                if (getready == -1)
                {
                    pnp.multi_expert_level(racket_left2);
                }
                if (racket.Left <= playground.Left)   ///collusion of racket with boundary
                {
                    racket.Left -= racket.Left;
                }

                if (racket.Right >= playground.Right)   ///collusion of racket with boundary
                {
                    racket.Left = 1040;
                }
                if (racket2.Left <= playground.Left)   ///collusion of racket2 with boundary
                {
                    racket2.Left -= racket2.Left;
                }

                if (racket2.Right >= playground.Right)   ///collusion of racket2 with boundary
                {
                    racket2.Left = 1040;
                }

            }
            #endregion multi_expert

            //play as server and easy
            #region server_easy
            else if (playAs_server == true && play_easy == true && isPlayerConnected_to_server == true)
            {
                creatserver_btn.Visible = false;
                ipaddress_lbl.Visible = false;
                ip_tb.Visible = false;
                joinplayer_btn.Visible = false;
                backtodificulty_pb.Visible = false;
                waitingforplyr_lbl.Visible = false;
                options_lbl.Visible = false;
                volume_pb.Visible = false;
                exit_pb.Visible = false;

                playground.Visible = true;
                racket.Visible = true;
                ball.Visible = true;
                p2_score_lbl.Visible = true;
                p1_points_lbl.Visible = true;
                getready_lbl.Visible = false;

                Player1.Visible = true;
                Player2.Visible = true;

                p1_score_lbl.Visible = false;
                p1_points_lbl.Visible = false;
                p2_score_lbl.Visible = false;
                p2_points_lbl.Visible = false;

                racket2.Visible = true;
                racket.Width = 300;
                racket.BackgroundImageLayout = ImageLayout.None;
                racket2.Width = 300;
                racket2.BackgroundImageLayout = ImageLayout.None;

                if (getready == -1)
                {  //sender
                    try
                    {
                        int rac = racket.Location.X;
                        int ball_X = ball.Location.X;
                        int ball_Y = ball.Location.Y;

                        NetworkStream ns = connected_client.GetStream();
                        StreamWriter sw = new StreamWriter(ns);

                        string rec_ball_posi = rac.ToString() + " " + ball_X.ToString() + " " + ball_Y.ToString();

                        sw.WriteLine(rec_ball_posi);
                        sw.Flush();

                        NetworkStream ns1 = connected_client.GetStream();
                        StreamReader sr = new StreamReader(ns1);

                        string recmsg = sr.ReadLine();
                        int rac2_posi = Convert.ToInt32(recmsg);

                        //this position is recieved from oponent and set it as a perameter
                        pnp.online_easy_asServer(rac2_posi);
                    }
                    catch (SocketException)
                    {
                    }

                }
                if (racket.Left <= playground.Left)   ///collusion of racket with boundary
                {
                    racket.Left -= racket.Left;
                }

                if (racket.Right >= playground.Right)   ///collusion of racket with boundary
                {
                    racket.Left = 1040;
                }
                if (racket2.Left <= playground.Left)   ///collusion of racket2 with boundary
                {
                    racket2.Left -= racket2.Left;
                }

                if (racket2.Right >= playground.Right)   ///collusion of racket2 with boundary
                {
                    racket2.Left = 1040;
                }

            }
            #endregion server_easy

            //play as server and hard
            #region server_hard
            else if (playAs_server == true && play_hard == true && isPlayerConnected_to_server == true)
            {
                creatserver_btn.Visible = false;
                ipaddress_lbl.Visible = false;
                ip_tb.Visible = false;
                joinplayer_btn.Visible = false;
                backtodificulty_pb.Visible = false;
                waitingforplyr_lbl.Visible = false;
                options_lbl.Visible = false;
                volume_pb.Visible = false;
                exit_pb.Visible = false;

                playground.Visible = true;
                racket.Visible = true;
                ball.Visible = true;
                p2_score_lbl.Visible = true;
                p1_points_lbl.Visible = true;
                getready_lbl.Visible = false;

                Player1.Visible = true;
                Player2.Visible = true;

                p1_score_lbl.Visible = false;
                p1_points_lbl.Visible = false;
                p2_score_lbl.Visible = false;
                p2_points_lbl.Visible = false;

                racket2.Visible = true;
                racket.BackgroundImageLayout = ImageLayout.None;
                racket2.BackgroundImageLayout = ImageLayout.None;

                if (getready == -1)
                {  //sender
                    try
                    {
                        int rac = racket.Location.X;
                        int ball_X = ball.Location.X;
                        int ball_Y = ball.Location.Y;

                        NetworkStream ns = connected_client.GetStream();
                        StreamWriter sw = new StreamWriter(ns);

                        string rec_ball_posi = rac.ToString() + " " + ball_X.ToString() + " " + ball_Y.ToString();

                        sw.WriteLine(rec_ball_posi);
                        sw.Flush();

                        NetworkStream ns1 = connected_client.GetStream();
                        StreamReader sr = new StreamReader(ns1);

                        string recmsg = sr.ReadLine();
                        int rac2_posi = Convert.ToInt32(recmsg);

                        //this position is recieved from oponent and set it as a perameter
                        pnp.online_hard_asServer(rac2_posi);
                    }
                    catch (SocketException)
                    {
                    }

                }
                if (racket.Left <= playground.Left)   ///collusion of racket with boundary
                {
                    racket.Left -= racket.Left;
                }

                if (racket.Right >= playground.Right)   ///collusion of racket with boundary
                {
                    racket.Left = 1040;
                }
                if (racket2.Left <= playground.Left)   ///collusion of racket2 with boundary
                {
                    racket2.Left -= racket2.Left;
                }

                if (racket2.Right >= playground.Right)   ///collusion of racket2 with boundary
                {
                    racket2.Left = 1040;
                }

            }
            #endregion server_hard

            //play as server and expert
            #region server_expert
            else if (playAs_server == true && play_expert == true && isPlayerConnected_to_server == true)
            {
                creatserver_btn.Visible = false;
                ipaddress_lbl.Visible = false;
                ip_tb.Visible = false;
                joinplayer_btn.Visible = false;
                backtodificulty_pb.Visible = false;
                waitingforplyr_lbl.Visible = false;
                options_lbl.Visible = false;
                volume_pb.Visible = false;
                exit_pb.Visible = false;

                playground.Visible = true;
                racket.Visible = true;
                ball.Visible = true;
                ball2.Visible = true;
                p2_score_lbl.Visible = true;
                p1_points_lbl.Visible = true;
                getready_lbl.Visible = false;

                Player1.Visible = true;
                Player2.Visible = true;

                p1_score_lbl.Visible = false;
                p1_points_lbl.Visible = false;
                p2_score_lbl.Visible = false;
                p2_points_lbl.Visible = false;

                racket2.Visible = true;
                racket.BackgroundImageLayout = ImageLayout.None;
                racket2.BackgroundImageLayout = ImageLayout.None;

                if (getready == -1)
                {  //sender
                    try
                    {
                        int rac = racket.Location.X;
                        int ball_X = ball.Location.X;
                        int ball_Y = ball.Location.Y;
                        int ball2_X = ball2.Location.X;
                        int ball2_Y = ball2.Location.Y;

                        NetworkStream ns = connected_client.GetStream();
                        StreamWriter sw = new StreamWriter(ns);

                        string rec_ball_posi = rac.ToString() + " " + ball_X.ToString() + " " + ball_Y.ToString() + " " + ball2_X.ToString() + " " + ball2_Y.ToString();

                        sw.WriteLine(rec_ball_posi);
                        sw.Flush();

                        NetworkStream ns1 = connected_client.GetStream();
                        StreamReader sr = new StreamReader(ns1);

                        string recmsg = sr.ReadLine();
                        int rac2_posi = Convert.ToInt32(recmsg);

                        //this position is recieved from oponent and set it as a perameter
                        pnp.online_expert_asServer(rac2_posi);
                    }
                    catch (SocketException)
                    {
                    }

                }
                if (racket.Left <= playground.Left)   ///collusion of racket with boundary
                {
                    racket.Left -= racket.Left;
                }

                if (racket.Right >= playground.Right)   ///collusion of racket with boundary
                {
                    racket.Left = 1040;
                }
                if (racket2.Left <= playground.Left)   ///collusion of racket2 with boundary
                {
                    racket2.Left -= racket2.Left;
                }

                if (racket2.Right >= playground.Right)   ///collusion of racket2 with boundary
                {
                    racket2.Left = 1040;
                }

            }
            #endregion server_expert

            //play as player and easy
            #region player_easy
            else if (playAs_player == true && play_easy == true && isMeConnected == true)
            {
                creatserver_btn.Visible = false;
                ipaddress_lbl.Visible = false;
                ip_tb.Visible = false;
                joinplayer_btn.Visible = false;
                backtodificulty_pb.Visible = false;
                waitingforplyr_lbl.Visible = false;
                options_lbl.Visible = false;
                volume_pb.Visible = false;
                exit_pb.Visible = false;

                playground.Visible = true;
                racket.Visible = true;
                ball.Visible = true;
                p2_score_lbl.Visible = true;
                p1_points_lbl.Visible = true;
                getready_lbl.Visible = false;

                Player1.Visible = true;
                Player2.Visible = true;

                p1_score_lbl.Visible = false;
                p1_points_lbl.Visible = false;
                p2_score_lbl.Visible = false;
                p2_points_lbl.Visible = false;

                racket2.Visible = true;
                racket.Width = 300;
                racket.BackgroundImageLayout = ImageLayout.None;
                racket2.Width = 300;
                racket2.BackgroundImageLayout = ImageLayout.None;

                if (getready == -1)
                {//reciever
                    try
                    {
                        NetworkStream ns = c.GetStream();
                        StreamWriter sw = new StreamWriter(ns);

                        int rac = racket2.Location.X;
                        string rec_posi = rac.ToString();

                        sw.WriteLine(rec_posi);
                        sw.Flush();



                        NetworkStream ns1 = c.GetStream();
                        StreamReader sr = new StreamReader(ns1);

                        string recievemsg = sr.ReadLine();

                        var myarr = recievemsg.Split(' ');

                        int rac1_posi = Convert.ToInt32(myarr[0]);
                        int ball_X = Convert.ToInt32(myarr[1]);
                        int ball_Y = Convert.ToInt32(myarr[2]);


                        //this position is recieved from oponent and set it as a perameter
                        pnp.online_easy_asPlayer(rac1_posi, ball_X, ball_Y);
                    }
                    catch (SocketException)
                    {
                    }

                }
                if (racket.Left <= playground.Left)   ///collusion of racket with boundary
                {
                    racket.Left -= racket.Left;
                }

                if (racket.Right >= playground.Right)   ///collusion of racket with boundary
                {
                    racket.Left = 1040;
                }
                if (racket2.Left <= playground.Left)   ///collusion of racket2 with boundary
                {
                    racket2.Left -= racket2.Left;
                }

                if (racket2.Right >= playground.Right)   ///collusion of racket2 with boundary
                {
                    racket2.Left = 1040;
                }

            }
            #endregion player_easy

            //play as player and hard
            #region player_hard
            else if (playAs_player == true && play_hard == true && isMeConnected == true)
            {
                creatserver_btn.Visible = false;
                ipaddress_lbl.Visible = false;
                ip_tb.Visible = false;
                joinplayer_btn.Visible = false;
                backtodificulty_pb.Visible = false;
                waitingforplyr_lbl.Visible = false;
                options_lbl.Visible = false;
                volume_pb.Visible = false;
                exit_pb.Visible = false;

                playground.Visible = true;
                racket.Visible = true;
                ball.Visible = true;
                p2_score_lbl.Visible = true;
                p1_points_lbl.Visible = true;
                getready_lbl.Visible = false;

                Player1.Visible = true;
                Player2.Visible = true;

                p1_score_lbl.Visible = false;
                p1_points_lbl.Visible = false;
                p2_score_lbl.Visible = false;
                p2_points_lbl.Visible = false;

                racket2.Visible = true;
                racket.BackgroundImageLayout = ImageLayout.None;
                racket2.BackgroundImageLayout = ImageLayout.None;

                if (getready == -1)
                {//reciever
                    try
                    {

                        NetworkStream ns = c.GetStream();
                        StreamWriter sw = new StreamWriter(ns);

                        int rac = racket2.Location.X;
                        string rec_posi = rac.ToString();

                        sw.WriteLine(rec_posi);
                        sw.Flush();



                        NetworkStream ns1 = c.GetStream();
                        StreamReader sr = new StreamReader(ns1);

                        string recievemsg = sr.ReadLine();

                        var myarr = recievemsg.Split(' ');

                        int rac1_posi = Convert.ToInt32(myarr[0]);
                        int ball_X = Convert.ToInt32(myarr[1]);
                        int ball_Y = Convert.ToInt32(myarr[2]);


                        //this position is recieved from oponent and set it as a perameter
                        pnp.online_hard_asPlayer(rac1_posi, ball_X, ball_Y);
                    }
                    catch (SocketException)
                    {
                    }

                }
                if (racket.Left <= playground.Left)   ///collusion of racket with boundary
                {
                    racket.Left -= racket.Left;
                }

                if (racket.Right >= playground.Right)   ///collusion of racket with boundary
                {
                    racket.Left = 1040;
                }
                if (racket2.Left <= playground.Left)   ///collusion of racket2 with boundary
                {
                    racket2.Left -= racket2.Left;
                }

                if (racket2.Right >= playground.Right)   ///collusion of racket2 with boundary
                {
                    racket2.Left = 1040;
                }

            }
            #endregion player_hard

            //play as Player and expert
            #region player_expert
            else if (playAs_player == true && play_expert == true && isMeConnected == true)
            {
                creatserver_btn.Visible = false;
                ipaddress_lbl.Visible = false;
                ip_tb.Visible = false;
                joinplayer_btn.Visible = false;
                backtodificulty_pb.Visible = false;
                waitingforplyr_lbl.Visible = false;
                options_lbl.Visible = false;
                volume_pb.Visible = false;
                exit_pb.Visible = false;

                playground.Visible = true;
                racket.Visible = true;
                ball.Visible = true;
                ball2.Visible = true;
                p2_score_lbl.Visible = true;
                p1_points_lbl.Visible = true;
                getready_lbl.Visible = false;

                Player1.Visible = true;
                Player2.Visible = true;

                p1_score_lbl.Visible = false;
                p1_points_lbl.Visible = false;
                p2_score_lbl.Visible = false;
                p2_points_lbl.Visible = false;

                racket2.Visible = true;
                racket.BackgroundImageLayout = ImageLayout.None;
                racket2.BackgroundImageLayout = ImageLayout.None;

                if (getready == -1)
                {//reciever
                    try
                    {
                        NetworkStream ns = c.GetStream();
                        StreamWriter sw = new StreamWriter(ns);

                        int rac = racket2.Location.X;
                        string rec_posi = rac.ToString();

                        sw.WriteLine(rec_posi);
                        sw.Flush();

                        NetworkStream ns1 = c.GetStream();
                        StreamReader sr = new StreamReader(ns1);

                        string recievemsg = sr.ReadLine();

                        var myarr = recievemsg.Split(' ');

                        int rac1_posi = Convert.ToInt32(myarr[0]);
                        int ball_X = Convert.ToInt32(myarr[1]);
                        int ball_Y = Convert.ToInt32(myarr[2]);
                        int ball2_X = Convert.ToInt32(myarr[3]);
                        int ball2_Y = Convert.ToInt32(myarr[4]);


                        //this position is recieved from oponent and set it as a perameter
                        pnp.online_expert_asPlayer(rac1_posi, ball_X, ball_Y, ball2_X, ball2_Y);
                    }
                    catch (SocketException)
                    {
                    }

                }
                if (racket.Left <= playground.Left)   ///collusion of racket with boundary
                {
                    racket.Left -= racket.Left;
                }

                if (racket.Right >= playground.Right)   ///collusion of racket with boundary
                {
                    racket.Left = 1040;
                }
                if (racket2.Left <= playground.Left)   ///collusion of racket2 with boundary
                {
                    racket2.Left -= racket2.Left;
                }

                if (racket2.Right >= playground.Right)   ///collusion of racket2 with boundary
                {
                    racket2.Left = 1040;
                }

            }
            #endregion player_expert

        }//end of main timer1

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (getready > -1)
            {
                getready_lbl.Text = getready.ToString();
                getready--;
            }
            else
            {
                timer2.Stop();
                getready_lbl.Visible = false;
            }
        }

        private void volume_pb_Click(object sender, EventArgs e)
        {
            if (volume == true)
            {
                sp.Play();
                volume = false;
            }
            else
            {
                sp.Stop();
                volume = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            p2_score_lbl.Visible = false;
            p2_points_lbl.Visible = false;
            p1_score_lbl.Visible = false;
            p1_points_lbl.Visible = false;

            //sp.PlayLooping();
            //sp.Play();
        }

        public void AcceptClient(IAsyncResult res)
        {
            TcpListener tl = (TcpListener)res.AsyncState;
            connected_client = tl.EndAcceptTcpClient(res);

            timer2.Start();
            isPlayerConnected_to_server = true;

            MessageBox.Show("Server Status : Player connected !!!");
            waitingforplyr_lbl.Text = "Player Connected !!";
        }
    }
}
