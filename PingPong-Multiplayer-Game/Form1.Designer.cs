namespace PingPong_Multiplayer_Game
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.exit_pb = new System.Windows.Forms.PictureBox();
            this.backtodificulty_pb = new System.Windows.Forms.PictureBox();
            this.Player2 = new System.Windows.Forms.Label();
            this.Player1 = new System.Windows.Forms.Label();
            this.p2_points_lbl = new System.Windows.Forms.Label();
            this.p1_score_lbl = new System.Windows.Forms.Label();
            this.ipaddress_lbl = new System.Windows.Forms.Label();
            this.racket2 = new System.Windows.Forms.PictureBox();
            this.ball2 = new System.Windows.Forms.PictureBox();
            this.getready_lbl = new System.Windows.Forms.Label();
            this.p1_points_lbl = new System.Windows.Forms.Label();
            this.p2_score_lbl = new System.Windows.Forms.Label();
            this.gameover_lbl = new System.Windows.Forms.Label();
            this.ball = new System.Windows.Forms.PictureBox();
            this.racket = new System.Windows.Forms.PictureBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.ip_tb = new System.Windows.Forms.TextBox();
            this.joinplayer_btn = new System.Windows.Forms.Button();
            this.creatserver_btn = new System.Windows.Forms.Button();
            this.backtoplaymod_pb = new System.Windows.Forms.PictureBox();
            this.expert_btn = new System.Windows.Forms.Button();
            this.hard_btn = new System.Windows.Forms.Button();
            this.easy_btn = new System.Windows.Forms.Button();
            this.backtomain_pb = new System.Windows.Forms.PictureBox();
            this.onlineply_btn = new System.Windows.Forms.Button();
            this.multiplyr_btn = new System.Windows.Forms.Button();
            this.singleplyr_btn = new System.Windows.Forms.Button();
            this.volume_pb = new System.Windows.Forms.PictureBox();
            this.options_lbl = new System.Windows.Forms.Label();
            this.exitgame_btn = new System.Windows.Forms.Button();
            this.howtoply_btn = new System.Windows.Forms.Button();
            this.startgame_btn = new System.Windows.Forms.Button();
            this.waitingforplyr_lbl = new System.Windows.Forms.Label();
            this.howtoplaydesc_lbl = new System.Windows.Forms.Label();
            this.playground = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.exit_pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backtodificulty_pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.racket2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.racket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backtoplaymod_pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backtomain_pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.volume_pb)).BeginInit();
            this.playground.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // exit_pb
            // 
            this.exit_pb.BackColor = System.Drawing.Color.Transparent;
            this.exit_pb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit_pb.Image = ((System.Drawing.Image)(resources.GetObject("exit_pb.Image")));
            this.exit_pb.Location = new System.Drawing.Point(1205, 14);
            this.exit_pb.Name = "exit_pb";
            this.exit_pb.Size = new System.Drawing.Size(37, 31);
            this.exit_pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.exit_pb.TabIndex = 45;
            this.exit_pb.TabStop = false;
            this.exit_pb.Click += new System.EventHandler(this.exit_pb_Click);
            // 
            // backtodificulty_pb
            // 
            this.backtodificulty_pb.BackColor = System.Drawing.Color.Transparent;
            this.backtodificulty_pb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backtodificulty_pb.Image = ((System.Drawing.Image)(resources.GetObject("backtodificulty_pb.Image")));
            this.backtodificulty_pb.Location = new System.Drawing.Point(38, 12);
            this.backtodificulty_pb.Name = "backtodificulty_pb";
            this.backtodificulty_pb.Size = new System.Drawing.Size(100, 50);
            this.backtodificulty_pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.backtodificulty_pb.TabIndex = 44;
            this.backtodificulty_pb.TabStop = false;
            this.backtodificulty_pb.Visible = false;
            this.backtodificulty_pb.Click += new System.EventHandler(this.backtodificulty_pb_Click);
            // 
            // Player2
            // 
            this.Player2.AutoSize = true;
            this.Player2.BackColor = System.Drawing.Color.Transparent;
            this.Player2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player2.Location = new System.Drawing.Point(1159, 662);
            this.Player2.Name = "Player2";
            this.Player2.Size = new System.Drawing.Size(91, 25);
            this.Player2.TabIndex = 9;
            this.Player2.Text = "Player 2";
            this.Player2.Visible = false;
            // 
            // Player1
            // 
            this.Player1.AutoSize = true;
            this.Player1.BackColor = System.Drawing.Color.Transparent;
            this.Player1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player1.Location = new System.Drawing.Point(1159, 4);
            this.Player1.Name = "Player1";
            this.Player1.Size = new System.Drawing.Size(91, 25);
            this.Player1.TabIndex = 8;
            this.Player1.Text = "Player 1";
            this.Player1.Visible = false;
            // 
            // p2_points_lbl
            // 
            this.p2_points_lbl.AutoSize = true;
            this.p2_points_lbl.BackColor = System.Drawing.Color.Transparent;
            this.p2_points_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p2_points_lbl.Location = new System.Drawing.Point(1226, 3);
            this.p2_points_lbl.Name = "p2_points_lbl";
            this.p2_points_lbl.Size = new System.Drawing.Size(24, 25);
            this.p2_points_lbl.TabIndex = 1;
            this.p2_points_lbl.Text = "0";
            this.p2_points_lbl.Visible = false;
            // 
            // p1_score_lbl
            // 
            this.p1_score_lbl.AutoSize = true;
            this.p1_score_lbl.BackColor = System.Drawing.Color.Transparent;
            this.p1_score_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p1_score_lbl.Location = new System.Drawing.Point(1155, 664);
            this.p1_score_lbl.Name = "p1_score_lbl";
            this.p1_score_lbl.Size = new System.Drawing.Size(74, 25);
            this.p1_score_lbl.TabIndex = 1;
            this.p1_score_lbl.Text = "Score:";
            this.p1_score_lbl.Visible = false;
            // 
            // ipaddress_lbl
            // 
            this.ipaddress_lbl.AutoSize = true;
            this.ipaddress_lbl.BackColor = System.Drawing.Color.Transparent;
            this.ipaddress_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ipaddress_lbl.Location = new System.Drawing.Point(107, 383);
            this.ipaddress_lbl.Name = "ipaddress_lbl";
            this.ipaddress_lbl.Size = new System.Drawing.Size(173, 33);
            this.ipaddress_lbl.TabIndex = 43;
            this.ipaddress_lbl.Text = "IP Address :";
            this.ipaddress_lbl.Visible = false;
            // 
            // racket2
            // 
            this.racket2.BackColor = System.Drawing.Color.Black;
            this.racket2.Image = ((System.Drawing.Image)(resources.GetObject("racket2.Image")));
            this.racket2.Location = new System.Drawing.Point(581, 28);
            this.racket2.Name = "racket2";
            this.racket2.Size = new System.Drawing.Size(200, 20);
            this.racket2.TabIndex = 7;
            this.racket2.TabStop = false;
            this.racket2.Visible = false;
            // 
            // ball2
            // 
            this.ball2.BackColor = System.Drawing.Color.Transparent;
            this.ball2.Image = ((System.Drawing.Image)(resources.GetObject("ball2.Image")));
            this.ball2.Location = new System.Drawing.Point(70, 81);
            this.ball2.Name = "ball2";
            this.ball2.Size = new System.Drawing.Size(21, 21);
            this.ball2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ball2.TabIndex = 6;
            this.ball2.TabStop = false;
            this.ball2.Visible = false;
            // 
            // getready_lbl
            // 
            this.getready_lbl.AutoSize = true;
            this.getready_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 200.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getready_lbl.Location = new System.Drawing.Point(449, 167);
            this.getready_lbl.Name = "getready_lbl";
            this.getready_lbl.Size = new System.Drawing.Size(0, 302);
            this.getready_lbl.TabIndex = 5;
            this.getready_lbl.Visible = false;
            // 
            // p1_points_lbl
            // 
            this.p1_points_lbl.AutoSize = true;
            this.p1_points_lbl.BackColor = System.Drawing.Color.Transparent;
            this.p1_points_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p1_points_lbl.Location = new System.Drawing.Point(1224, 664);
            this.p1_points_lbl.Name = "p1_points_lbl";
            this.p1_points_lbl.Size = new System.Drawing.Size(24, 25);
            this.p1_points_lbl.TabIndex = 1;
            this.p1_points_lbl.Text = "0";
            this.p1_points_lbl.Visible = false;
            // 
            // p2_score_lbl
            // 
            this.p2_score_lbl.AutoSize = true;
            this.p2_score_lbl.BackColor = System.Drawing.Color.Transparent;
            this.p2_score_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p2_score_lbl.Location = new System.Drawing.Point(1155, 3);
            this.p2_score_lbl.Name = "p2_score_lbl";
            this.p2_score_lbl.Size = new System.Drawing.Size(74, 25);
            this.p2_score_lbl.TabIndex = 1;
            this.p2_score_lbl.Text = "Score:";
            this.p2_score_lbl.Visible = false;
            // 
            // gameover_lbl
            // 
            this.gameover_lbl.AutoSize = true;
            this.gameover_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameover_lbl.Location = new System.Drawing.Point(461, 239);
            this.gameover_lbl.Name = "gameover_lbl";
            this.gameover_lbl.Size = new System.Drawing.Size(363, 146);
            this.gameover_lbl.TabIndex = 2;
            this.gameover_lbl.Text = "Game Over\r\n  Esc - Exit\r\n";
            this.gameover_lbl.Visible = false;
            // 
            // ball
            // 
            this.ball.BackColor = System.Drawing.Color.Transparent;
            this.ball.Image = ((System.Drawing.Image)(resources.GetObject("ball.Image")));
            this.ball.Location = new System.Drawing.Point(43, 81);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(21, 21);
            this.ball.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ball.TabIndex = 1;
            this.ball.TabStop = false;
            this.ball.Visible = false;
            // 
            // racket
            // 
            this.racket.BackColor = System.Drawing.Color.Black;
            this.racket.Image = ((System.Drawing.Image)(resources.GetObject("racket.Image")));
            this.racket.Location = new System.Drawing.Point(581, 642);
            this.racket.Name = "racket";
            this.racket.Size = new System.Drawing.Size(200, 20);
            this.racket.TabIndex = 0;
            this.racket.TabStop = false;
            this.racket.Visible = false;
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // ip_tb
            // 
            this.ip_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ip_tb.Location = new System.Drawing.Point(286, 380);
            this.ip_tb.Name = "ip_tb";
            this.ip_tb.Size = new System.Drawing.Size(233, 40);
            this.ip_tb.TabIndex = 42;
            this.ip_tb.Text = "192.168.1.45";
            this.ip_tb.Visible = false;
            // 
            // joinplayer_btn
            // 
            this.joinplayer_btn.BackColor = System.Drawing.Color.Peru;
            this.joinplayer_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.joinplayer_btn.ForeColor = System.Drawing.Color.Red;
            this.joinplayer_btn.Location = new System.Drawing.Point(525, 379);
            this.joinplayer_btn.Name = "joinplayer_btn";
            this.joinplayer_btn.Size = new System.Drawing.Size(187, 40);
            this.joinplayer_btn.TabIndex = 41;
            this.joinplayer_btn.Text = "Join player";
            this.joinplayer_btn.UseVisualStyleBackColor = false;
            this.joinplayer_btn.Visible = false;
            this.joinplayer_btn.Click += new System.EventHandler(this.joinplayer_btn_Click);
            // 
            // creatserver_btn
            // 
            this.creatserver_btn.BackColor = System.Drawing.Color.Peru;
            this.creatserver_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creatserver_btn.ForeColor = System.Drawing.Color.Red;
            this.creatserver_btn.Location = new System.Drawing.Point(417, 265);
            this.creatserver_btn.Name = "creatserver_btn";
            this.creatserver_btn.Size = new System.Drawing.Size(295, 81);
            this.creatserver_btn.TabIndex = 40;
            this.creatserver_btn.Text = "Creat server and wait for the player";
            this.creatserver_btn.UseVisualStyleBackColor = false;
            this.creatserver_btn.Visible = false;
            this.creatserver_btn.Click += new System.EventHandler(this.creatserver_btn_Click);
            // 
            // backtoplaymod_pb
            // 
            this.backtoplaymod_pb.BackColor = System.Drawing.Color.Transparent;
            this.backtoplaymod_pb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backtoplaymod_pb.Image = ((System.Drawing.Image)(resources.GetObject("backtoplaymod_pb.Image")));
            this.backtoplaymod_pb.Location = new System.Drawing.Point(25, 12);
            this.backtoplaymod_pb.Name = "backtoplaymod_pb";
            this.backtoplaymod_pb.Size = new System.Drawing.Size(100, 50);
            this.backtoplaymod_pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.backtoplaymod_pb.TabIndex = 39;
            this.backtoplaymod_pb.TabStop = false;
            this.backtoplaymod_pb.Visible = false;
            this.backtoplaymod_pb.Click += new System.EventHandler(this.backtoplaymod_pb_Click);
            // 
            // expert_btn
            // 
            this.expert_btn.BackColor = System.Drawing.Color.Peru;
            this.expert_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expert_btn.ForeColor = System.Drawing.Color.Red;
            this.expert_btn.Location = new System.Drawing.Point(438, 366);
            this.expert_btn.Name = "expert_btn";
            this.expert_btn.Size = new System.Drawing.Size(295, 81);
            this.expert_btn.TabIndex = 38;
            this.expert_btn.Text = "Expert";
            this.expert_btn.UseVisualStyleBackColor = false;
            this.expert_btn.Visible = false;
            this.expert_btn.Click += new System.EventHandler(this.expert_btn_Click);
            // 
            // hard_btn
            // 
            this.hard_btn.BackColor = System.Drawing.Color.Peru;
            this.hard_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hard_btn.ForeColor = System.Drawing.Color.Red;
            this.hard_btn.Location = new System.Drawing.Point(438, 265);
            this.hard_btn.Name = "hard_btn";
            this.hard_btn.Size = new System.Drawing.Size(295, 81);
            this.hard_btn.TabIndex = 37;
            this.hard_btn.Text = "Hard";
            this.hard_btn.UseVisualStyleBackColor = false;
            this.hard_btn.Visible = false;
            this.hard_btn.Click += new System.EventHandler(this.hard_btn_Click);
            // 
            // easy_btn
            // 
            this.easy_btn.BackColor = System.Drawing.Color.Peru;
            this.easy_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.easy_btn.ForeColor = System.Drawing.Color.Red;
            this.easy_btn.Location = new System.Drawing.Point(438, 164);
            this.easy_btn.Name = "easy_btn";
            this.easy_btn.Size = new System.Drawing.Size(295, 81);
            this.easy_btn.TabIndex = 36;
            this.easy_btn.Text = "Easy";
            this.easy_btn.UseVisualStyleBackColor = false;
            this.easy_btn.Visible = false;
            this.easy_btn.Click += new System.EventHandler(this.easy_btn_Click);
            // 
            // backtomain_pb
            // 
            this.backtomain_pb.BackColor = System.Drawing.Color.Transparent;
            this.backtomain_pb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backtomain_pb.Image = ((System.Drawing.Image)(resources.GetObject("backtomain_pb.Image")));
            this.backtomain_pb.Location = new System.Drawing.Point(12, 12);
            this.backtomain_pb.Name = "backtomain_pb";
            this.backtomain_pb.Size = new System.Drawing.Size(100, 50);
            this.backtomain_pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.backtomain_pb.TabIndex = 34;
            this.backtomain_pb.TabStop = false;
            this.backtomain_pb.Visible = false;
            this.backtomain_pb.Click += new System.EventHandler(this.backtomain_pb_Click);
            // 
            // onlineply_btn
            // 
            this.onlineply_btn.BackColor = System.Drawing.Color.Peru;
            this.onlineply_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.onlineply_btn.ForeColor = System.Drawing.Color.Red;
            this.onlineply_btn.Location = new System.Drawing.Point(454, 366);
            this.onlineply_btn.Name = "onlineply_btn";
            this.onlineply_btn.Size = new System.Drawing.Size(295, 81);
            this.onlineply_btn.TabIndex = 33;
            this.onlineply_btn.Text = "Play Online";
            this.onlineply_btn.UseVisualStyleBackColor = false;
            this.onlineply_btn.Visible = false;
            this.onlineply_btn.Click += new System.EventHandler(this.onlineply_btn_Click);
            // 
            // multiplyr_btn
            // 
            this.multiplyr_btn.BackColor = System.Drawing.Color.Peru;
            this.multiplyr_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiplyr_btn.ForeColor = System.Drawing.Color.Red;
            this.multiplyr_btn.Location = new System.Drawing.Point(454, 265);
            this.multiplyr_btn.Name = "multiplyr_btn";
            this.multiplyr_btn.Size = new System.Drawing.Size(295, 81);
            this.multiplyr_btn.TabIndex = 32;
            this.multiplyr_btn.Text = "Multiplayer (Same Compuert)";
            this.multiplyr_btn.UseVisualStyleBackColor = false;
            this.multiplyr_btn.Visible = false;
            this.multiplyr_btn.Click += new System.EventHandler(this.multiplyr_btn_Click);
            // 
            // singleplyr_btn
            // 
            this.singleplyr_btn.BackColor = System.Drawing.Color.Peru;
            this.singleplyr_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.singleplyr_btn.ForeColor = System.Drawing.Color.Red;
            this.singleplyr_btn.Location = new System.Drawing.Point(454, 164);
            this.singleplyr_btn.Name = "singleplyr_btn";
            this.singleplyr_btn.Size = new System.Drawing.Size(295, 81);
            this.singleplyr_btn.TabIndex = 31;
            this.singleplyr_btn.Text = "Single Player";
            this.singleplyr_btn.UseVisualStyleBackColor = false;
            this.singleplyr_btn.Visible = false;
            this.singleplyr_btn.Click += new System.EventHandler(this.singleplyr_btn_Click);
            // 
            // volume_pb
            // 
            this.volume_pb.BackColor = System.Drawing.Color.Transparent;
            this.volume_pb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.volume_pb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.volume_pb.Image = ((System.Drawing.Image)(resources.GetObject("volume_pb.Image")));
            this.volume_pb.Location = new System.Drawing.Point(13, 642);
            this.volume_pb.Name = "volume_pb";
            this.volume_pb.Size = new System.Drawing.Size(54, 40);
            this.volume_pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.volume_pb.TabIndex = 30;
            this.volume_pb.TabStop = false;
            this.volume_pb.Click += new System.EventHandler(this.volume_pb_Click);
            // 
            // options_lbl
            // 
            this.options_lbl.AutoSize = true;
            this.options_lbl.BackColor = System.Drawing.Color.Transparent;
            this.options_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.options_lbl.ForeColor = System.Drawing.Color.Red;
            this.options_lbl.Location = new System.Drawing.Point(5, 596);
            this.options_lbl.Name = "options_lbl";
            this.options_lbl.Size = new System.Drawing.Size(156, 39);
            this.options_lbl.TabIndex = 29;
            this.options_lbl.Text = "Options :";
            // 
            // exitgame_btn
            // 
            this.exitgame_btn.BackColor = System.Drawing.Color.Peru;
            this.exitgame_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitgame_btn.ForeColor = System.Drawing.Color.Red;
            this.exitgame_btn.Location = new System.Drawing.Point(469, 366);
            this.exitgame_btn.Name = "exitgame_btn";
            this.exitgame_btn.Size = new System.Drawing.Size(295, 81);
            this.exitgame_btn.TabIndex = 28;
            this.exitgame_btn.Text = "Exit Game";
            this.exitgame_btn.UseVisualStyleBackColor = false;
            this.exitgame_btn.Click += new System.EventHandler(this.exitgame_btn_Click);
            // 
            // howtoply_btn
            // 
            this.howtoply_btn.BackColor = System.Drawing.Color.Peru;
            this.howtoply_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.howtoply_btn.ForeColor = System.Drawing.Color.Red;
            this.howtoply_btn.Location = new System.Drawing.Point(469, 265);
            this.howtoply_btn.Name = "howtoply_btn";
            this.howtoply_btn.Size = new System.Drawing.Size(295, 81);
            this.howtoply_btn.TabIndex = 27;
            this.howtoply_btn.Text = "How To Play";
            this.howtoply_btn.UseVisualStyleBackColor = false;
            this.howtoply_btn.Click += new System.EventHandler(this.howtoply_btn_Click);
            // 
            // startgame_btn
            // 
            this.startgame_btn.BackColor = System.Drawing.Color.Peru;
            this.startgame_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startgame_btn.ForeColor = System.Drawing.Color.Red;
            this.startgame_btn.Location = new System.Drawing.Point(469, 164);
            this.startgame_btn.Name = "startgame_btn";
            this.startgame_btn.Size = new System.Drawing.Size(295, 81);
            this.startgame_btn.TabIndex = 26;
            this.startgame_btn.Text = "Start Game";
            this.startgame_btn.UseVisualStyleBackColor = false;
            this.startgame_btn.Click += new System.EventHandler(this.startgame_btn_Click);
            // 
            // waitingforplyr_lbl
            // 
            this.waitingforplyr_lbl.AutoSize = true;
            this.waitingforplyr_lbl.BackColor = System.Drawing.Color.Transparent;
            this.waitingforplyr_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.waitingforplyr_lbl.ForeColor = System.Drawing.Color.Red;
            this.waitingforplyr_lbl.Location = new System.Drawing.Point(718, 274);
            this.waitingforplyr_lbl.Name = "waitingforplyr_lbl";
            this.waitingforplyr_lbl.Size = new System.Drawing.Size(362, 62);
            this.waitingforplyr_lbl.TabIndex = 46;
            this.waitingforplyr_lbl.Text = "Server has been created and\r\n     waiting for the player !!!";
            this.waitingforplyr_lbl.Visible = false;
            // 
            // howtoplaydesc_lbl
            // 
            this.howtoplaydesc_lbl.AutoSize = true;
            this.howtoplaydesc_lbl.BackColor = System.Drawing.Color.Transparent;
            this.howtoplaydesc_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.howtoplaydesc_lbl.ForeColor = System.Drawing.Color.Red;
            this.howtoplaydesc_lbl.Location = new System.Drawing.Point(365, 235);
            this.howtoplaydesc_lbl.Name = "howtoplaydesc_lbl";
            this.howtoplaydesc_lbl.Size = new System.Drawing.Size(463, 260);
            this.howtoplaydesc_lbl.TabIndex = 35;
            this.howtoplaydesc_lbl.Text = resources.GetString("howtoplaydesc_lbl.Text");
            this.howtoplaydesc_lbl.Visible = false;
            // 
            // playground
            // 
            this.playground.Controls.Add(this.Player2);
            this.playground.Controls.Add(this.Player1);
            this.playground.Controls.Add(this.p2_points_lbl);
            this.playground.Controls.Add(this.p1_score_lbl);
            this.playground.Controls.Add(this.racket2);
            this.playground.Controls.Add(this.ball2);
            this.playground.Controls.Add(this.getready_lbl);
            this.playground.Controls.Add(this.p1_points_lbl);
            this.playground.Controls.Add(this.p2_score_lbl);
            this.playground.Controls.Add(this.gameover_lbl);
            this.playground.Controls.Add(this.ball);
            this.playground.Controls.Add(this.racket);
            this.playground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.playground.Location = new System.Drawing.Point(0, 0);
            this.playground.Name = "playground";
            this.playground.Size = new System.Drawing.Size(1254, 691);
            this.playground.TabIndex = 47;
            this.playground.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1254, 691);
            this.Controls.Add(this.exit_pb);
            this.Controls.Add(this.backtodificulty_pb);
            this.Controls.Add(this.ipaddress_lbl);
            this.Controls.Add(this.ip_tb);
            this.Controls.Add(this.joinplayer_btn);
            this.Controls.Add(this.creatserver_btn);
            this.Controls.Add(this.backtoplaymod_pb);
            this.Controls.Add(this.expert_btn);
            this.Controls.Add(this.hard_btn);
            this.Controls.Add(this.easy_btn);
            this.Controls.Add(this.backtomain_pb);
            this.Controls.Add(this.onlineply_btn);
            this.Controls.Add(this.multiplyr_btn);
            this.Controls.Add(this.singleplyr_btn);
            this.Controls.Add(this.volume_pb);
            this.Controls.Add(this.options_lbl);
            this.Controls.Add(this.exitgame_btn);
            this.Controls.Add(this.howtoply_btn);
            this.Controls.Add(this.startgame_btn);
            this.Controls.Add(this.waitingforplyr_lbl);
            this.Controls.Add(this.howtoplaydesc_lbl);
            this.Controls.Add(this.playground);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "Play Ground";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.exit_pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backtodificulty_pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.racket2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.racket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backtoplaymod_pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backtomain_pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.volume_pb)).EndInit();
            this.playground.ResumeLayout(false);
            this.playground.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox exit_pb;
        private System.Windows.Forms.PictureBox backtodificulty_pb;
        private System.Windows.Forms.Label Player2;
        private System.Windows.Forms.Label Player1;
        private System.Windows.Forms.Label p2_points_lbl;
        private System.Windows.Forms.Label p1_score_lbl;
        private System.Windows.Forms.Label ipaddress_lbl;
        private System.Windows.Forms.PictureBox racket2;
        private System.Windows.Forms.PictureBox ball2;
        private System.Windows.Forms.Label getready_lbl;
        private System.Windows.Forms.Label p1_points_lbl;
        private System.Windows.Forms.Label p2_score_lbl;
        private System.Windows.Forms.Label gameover_lbl;
        private System.Windows.Forms.PictureBox ball;
        private System.Windows.Forms.PictureBox racket;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.TextBox ip_tb;
        private System.Windows.Forms.Button joinplayer_btn;
        private System.Windows.Forms.Button creatserver_btn;
        private System.Windows.Forms.PictureBox backtoplaymod_pb;
        private System.Windows.Forms.Button expert_btn;
        private System.Windows.Forms.Button hard_btn;
        private System.Windows.Forms.Button easy_btn;
        private System.Windows.Forms.PictureBox backtomain_pb;
        private System.Windows.Forms.Button onlineply_btn;
        private System.Windows.Forms.Button multiplyr_btn;
        private System.Windows.Forms.Button singleplyr_btn;
        private System.Windows.Forms.PictureBox volume_pb;
        private System.Windows.Forms.Label options_lbl;
        private System.Windows.Forms.Button exitgame_btn;
        private System.Windows.Forms.Button howtoply_btn;
        private System.Windows.Forms.Button startgame_btn;
        private System.Windows.Forms.Label waitingforplyr_lbl;
        private System.Windows.Forms.Label howtoplaydesc_lbl;
        private System.Windows.Forms.Panel playground;
    }
}

