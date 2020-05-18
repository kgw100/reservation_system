namespace reservation_System
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgvResSts = new System.Windows.Forms.DataGridView();
            this.sts_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sts_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sts_pos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.seatList = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tb_pos = new System.Windows.Forms.TextBox();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.reserv_btn = new System.Windows.Forms.Button();
            this.cls_btn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.gb_libSts = new System.Windows.Forms.GroupBox();
            this.noUsedCount = new System.Windows.Forms.Label();
            this.usedCount = new System.Windows.Forms.Label();
            this.totalCount = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResSts)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gb_libSts.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.groupBox4);
            this.panel3.Controls.Add(this.groupBox3);
            this.panel3.Controls.Add(this.groupBox2);
            this.panel3.Controls.Add(this.gb_libSts);
            this.panel3.Location = new System.Drawing.Point(9, 6);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(959, 661);
            this.panel3.TabIndex = 6;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgvResSts);
            this.groupBox4.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox4.Location = new System.Drawing.Point(5, 461);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Size = new System.Drawing.Size(949, 195);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "예약 현황";
            // 
            // dgvResSts
            // 
            this.dgvResSts.AllowUserToAddRows = false;
            this.dgvResSts.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvResSts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResSts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sts_id,
            this.sts_name,
            this.sts_pos});
            this.dgvResSts.Location = new System.Drawing.Point(6, 21);
            this.dgvResSts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvResSts.Name = "dgvResSts";
            this.dgvResSts.ReadOnly = true;
            this.dgvResSts.RowTemplate.Height = 27;
            this.dgvResSts.Size = new System.Drawing.Size(937, 168);
            this.dgvResSts.TabIndex = 7;
            // 
            // sts_id
            // 
            this.sts_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.sts_id.HeaderText = "학번";
            this.sts_id.Name = "sts_id";
            this.sts_id.ReadOnly = true;
            this.sts_id.Width = 170;
            // 
            // sts_name
            // 
            this.sts_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.sts_name.HeaderText = "이름";
            this.sts_name.Name = "sts_name";
            this.sts_name.ReadOnly = true;
            this.sts_name.Width = 120;
            // 
            // sts_pos
            // 
            this.sts_pos.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sts_pos.HeaderText = "좌석위치";
            this.sts_pos.Name = "sts_pos";
            this.sts_pos.ReadOnly = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.seatList);
            this.groupBox3.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox3.Location = new System.Drawing.Point(5, 122);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(949, 333);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "좌석 현황";
            // 
            // seatList
            // 
            this.seatList.Location = new System.Drawing.Point(7, 21);
            this.seatList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.seatList.Name = "seatList";
            this.seatList.Size = new System.Drawing.Size(935, 308);
            this.seatList.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tb_pos);
            this.groupBox2.Controls.Add(this.tb_id);
            this.groupBox2.Controls.Add(this.tb_name);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.reserv_btn);
            this.groupBox2.Controls.Add(this.cls_btn);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox2.Location = new System.Drawing.Point(280, 2);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(360, 112);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "예약 / 종료";
            // 
            // tb_pos
            // 
            this.tb_pos.Font = new System.Drawing.Font("굴림", 8F);
            this.tb_pos.Location = new System.Drawing.Point(105, 21);
            this.tb_pos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_pos.Name = "tb_pos";
            this.tb_pos.ReadOnly = true;
            this.tb_pos.Size = new System.Drawing.Size(119, 23);
            this.tb_pos.TabIndex = 9;
            // 
            // tb_id
            // 
            this.tb_id.Font = new System.Drawing.Font("굴림", 8F);
            this.tb_id.Location = new System.Drawing.Point(105, 50);
            this.tb_id.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(119, 23);
            this.tb_id.TabIndex = 12;
            this.tb_id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbID_Check);
            // 
            // tb_name
            // 
            this.tb_name.Font = new System.Drawing.Font("굴림", 8F);
            this.tb_name.Location = new System.Drawing.Point(105, 82);
            this.tb_name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(119, 23);
            this.tb_name.TabIndex = 13;
            this.tb_name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbName_Check);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(6, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 15);
            this.label6.TabIndex = 6;
            this.label6.Text = "좌석 번호";
            // 
            // reserv_btn
            // 
            this.reserv_btn.Location = new System.Drawing.Point(265, 24);
            this.reserv_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.reserv_btn.Name = "reserv_btn";
            this.reserv_btn.Size = new System.Drawing.Size(75, 36);
            this.reserv_btn.TabIndex = 5;
            this.reserv_btn.Text = "예약";
            this.reserv_btn.UseVisualStyleBackColor = true;
            this.reserv_btn.Click += new System.EventHandler(this.reservBtn_Click);
            // 
            // cls_btn
            // 
            this.cls_btn.Location = new System.Drawing.Point(265, 68);
            this.cls_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cls_btn.Name = "cls_btn";
            this.cls_btn.Size = new System.Drawing.Size(75, 36);
            this.cls_btn.TabIndex = 6;
            this.cls_btn.Text = "종료";
            this.cls_btn.UseVisualStyleBackColor = true;
            this.cls_btn.Click += new System.EventHandler(this.cls_btn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(6, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 15);
            this.label7.TabIndex = 7;
            this.label7.Text = "사용자 학번";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.Location = new System.Drawing.Point(6, 84);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 15);
            this.label8.TabIndex = 8;
            this.label8.Text = "사용자 이름";
            // 
            // gb_libSts
            // 
            this.gb_libSts.Controls.Add(this.noUsedCount);
            this.gb_libSts.Controls.Add(this.usedCount);
            this.gb_libSts.Controls.Add(this.totalCount);
            this.gb_libSts.Controls.Add(this.label4);
            this.gb_libSts.Controls.Add(this.label2);
            this.gb_libSts.Controls.Add(this.label3);
            this.gb_libSts.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.gb_libSts.Location = new System.Drawing.Point(5, 2);
            this.gb_libSts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gb_libSts.Name = "gb_libSts";
            this.gb_libSts.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gb_libSts.Size = new System.Drawing.Size(270, 112);
            this.gb_libSts.TabIndex = 8;
            this.gb_libSts.TabStop = false;
            this.gb_libSts.Text = "독서실 현황";
            // 
            // noUsedCount
            // 
            this.noUsedCount.AutoSize = true;
            this.noUsedCount.Location = new System.Drawing.Point(154, 76);
            this.noUsedCount.Name = "noUsedCount";
            this.noUsedCount.Size = new System.Drawing.Size(108, 15);
            this.noUsedCount.TabIndex = 6;
            this.noUsedCount.Text = "noUsedCount";
            // 
            // usedCount
            // 
            this.usedCount.AutoSize = true;
            this.usedCount.Location = new System.Drawing.Point(135, 52);
            this.usedCount.Name = "usedCount";
            this.usedCount.Size = new System.Drawing.Size(87, 15);
            this.usedCount.TabIndex = 5;
            this.usedCount.Text = "usedCount";
            // 
            // totalCount
            // 
            this.totalCount.AutoSize = true;
            this.totalCount.Location = new System.Drawing.Point(104, 29);
            this.totalCount.Name = "totalCount";
            this.totalCount.Size = new System.Drawing.Size(84, 15);
            this.totalCount.TabIndex = 4;
            this.totalCount.Text = "totalCount";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(6, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "사용 가능한 좌석 수 :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(6, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "전체 좌석 수 :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(6, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "사용중인 좌석 수 :";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 671);
            this.Controls.Add(this.panel3);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.Text = "ReservationSystem";
            this.panel3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResSts)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gb_libSts.ResumeLayout(false);
            this.gb_libSts.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.TextBox tb_pos;
        private System.Windows.Forms.Button cls_btn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button reserv_btn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvResSts;
        private System.Windows.Forms.DataGridViewTextBoxColumn sts_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn sts_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn sts_pos;
        private System.Windows.Forms.GroupBox gb_libSts;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label totalCount;
        private System.Windows.Forms.Label noUsedCount;
        private System.Windows.Forms.Label usedCount;
        private System.Windows.Forms.Panel seatList;

    }
}

