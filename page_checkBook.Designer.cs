namespace ticket
{
    partial class page_checkBook
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

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_name = new System.Windows.Forms.Label();
            this.listView_check = new System.Windows.Forms.ListView();
            this.column_num = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_seat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_time = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_audotoruim = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button_purchase = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_name.Location = new System.Drawing.Point(399, 115);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(140, 25);
            this.label_name.TabIndex = 0;
            this.label_name.Text = "님의 예매 내역";
            // 
            // listView_check
            // 
            this.listView_check.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView_check.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.column_num,
            this.column_title,
            this.column_audotoruim,
            this.column_time,
            this.column_seat,
            this.column_price});
            this.listView_check.Font = new System.Drawing.Font("굴림", 14F);
            this.listView_check.GridLines = true;
            this.listView_check.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView_check.Location = new System.Drawing.Point(93, 216);
            this.listView_check.MultiSelect = false;
            this.listView_check.Name = "listView_check";
            this.listView_check.Size = new System.Drawing.Size(1142, 351);
            this.listView_check.TabIndex = 1;
            this.listView_check.TileSize = new System.Drawing.Size(228, 100);
            this.listView_check.UseCompatibleStateImageBehavior = false;
            this.listView_check.View = System.Windows.Forms.View.Details;
            // 
            // column_num
            // 
            this.column_num.Text = "예약번호";
            this.column_num.Width = 89;
            // 
            // column_seat
            // 
            this.column_seat.DisplayIndex = 4;
            this.column_seat.Text = "좌석";
            this.column_seat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.column_seat.Width = 345;
            // 
            // column_time
            // 
            this.column_time.Text = "상영시간";
            this.column_time.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.column_time.Width = 158;
            // 
            // column_price
            // 
            this.column_price.DisplayIndex = 5;
            this.column_price.Text = "요금";
            this.column_price.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.column_price.Width = 165;
            // 
            // column_title
            // 
            this.column_title.Text = "제목";
            this.column_title.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.column_title.Width = 229;
            // 
            // column_audotoruim
            // 
            this.column_audotoruim.DisplayIndex = 2;
            this.column_audotoruim.Text = "상영관";
            this.column_audotoruim.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.column_audotoruim.Width = 109;
            // 
            // button_purchase
            // 
            this.button_purchase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(66)))), ((int)(((byte)(88)))));
            this.button_purchase.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_purchase.Location = new System.Drawing.Point(532, 587);
            this.button_purchase.Name = "button_purchase";
            this.button_purchase.Size = new System.Drawing.Size(142, 45);
            this.button_purchase.TabIndex = 9;
            this.button_purchase.Text = "확인";
            this.button_purchase.UseVisualStyleBackColor = false;
            this.button_purchase.Click += new System.EventHandler(this.button1_Click);
            // 
            // page_checkBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button_purchase);
            this.Controls.Add(this.listView_check);
            this.Controls.Add(this.label_name);
            this.Name = "page_checkBook";
            this.Size = new System.Drawing.Size(1280, 720);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.ListView listView_check;
        private System.Windows.Forms.ColumnHeader column_num;
        private System.Windows.Forms.ColumnHeader column_seat;
        private System.Windows.Forms.ColumnHeader column_time;
        private System.Windows.Forms.ColumnHeader column_price;
        private System.Windows.Forms.ColumnHeader column_title;
        private System.Windows.Forms.ColumnHeader column_audotoruim;
        private System.Windows.Forms.Button button_purchase;
    }
}
