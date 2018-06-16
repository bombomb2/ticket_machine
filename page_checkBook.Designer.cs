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
            this.column_seat,
            this.column_time,
            this.column_price});
            this.listView_check.Font = new System.Drawing.Font("굴림", 12F);
            this.listView_check.GridLines = true;
            this.listView_check.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView_check.Location = new System.Drawing.Point(194, 216);
            this.listView_check.MultiSelect = false;
            this.listView_check.Name = "listView_check";
            this.listView_check.Size = new System.Drawing.Size(661, 165);
            this.listView_check.TabIndex = 1;
            this.listView_check.TileSize = new System.Drawing.Size(228, 100);
            this.listView_check.UseCompatibleStateImageBehavior = false;
            this.listView_check.View = System.Windows.Forms.View.Details;
            // 
            // column_num
            // 
            this.column_num.Text = "예약번호";
            this.column_num.Width = 147;
            // 
            // column_seat
            // 
            this.column_seat.Text = "좌석";
            this.column_seat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.column_seat.Width = 168;
            // 
            // column_time
            // 
            this.column_time.Text = "상영시간";
            this.column_time.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.column_time.Width = 169;
            // 
            // column_price
            // 
            this.column_price.Text = "요금";
            this.column_price.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.column_price.Width = 174;
            // 
            // page_checkBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
    }
}
