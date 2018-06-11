namespace ticket
{
    partial class page2
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
            this.button_reservation = new System.Windows.Forms.Button();
            this.button_purchase = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_reservation
            // 
            this.button_reservation.AutoSize = true;
            this.button_reservation.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_reservation.Location = new System.Drawing.Point(811, 253);
            this.button_reservation.Name = "button_reservation";
            this.button_reservation.Size = new System.Drawing.Size(150, 107);
            this.button_reservation.TabIndex = 1;
            this.button_reservation.Text = "예약확인";
            this.button_reservation.UseVisualStyleBackColor = true;
            this.button_reservation.Click += new System.EventHandler(this.button2_clicked);
            // 
            // button_purchase
            // 
            this.button_purchase.AutoSize = true;
            this.button_purchase.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_purchase.Location = new System.Drawing.Point(346, 253);
            this.button_purchase.Name = "button_purchase";
            this.button_purchase.Size = new System.Drawing.Size(150, 107);
            this.button_purchase.TabIndex = 1;
            this.button_purchase.Text = "영화예매";
            this.button_purchase.UseVisualStyleBackColor = true;
            this.button_purchase.Click += new System.EventHandler(this.button2_clicked);
            // 
            // page2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.button_purchase);
            this.Controls.Add(this.button_reservation);
            this.Name = "page2";
            this.Size = new System.Drawing.Size(1280, 720);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_reservation;
        private System.Windows.Forms.Button button_purchase;
    }
}
