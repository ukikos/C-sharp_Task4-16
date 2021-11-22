
namespace С_sharp_Task4_16
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.partyNameLabel = new System.Windows.Forms.Label();
            this.partySizeLabel = new System.Windows.Forms.Label();
            this.partyPercentLabel = new System.Windows.Forms.Label();
            this.partyQLabel = new System.Windows.Forms.Label();
            this.partyNameTextBox = new System.Windows.Forms.TextBox();
            this.partySizeTextBox = new System.Windows.Forms.TextBox();
            this.partyPercentOfVotesTextBox = new System.Windows.Forms.TextBox();
            this.partyQTextBox = new System.Windows.Forms.TextBox();
            this.calculateQButton = new System.Windows.Forms.Button();
            this.partyInfo1Label = new System.Windows.Forms.Label();
            this.partyInfo1TextBox = new System.Windows.Forms.TextBox();
            this.partySizeLastYearLabel = new System.Windows.Forms.Label();
            this.partySizeLastYearTextBox = new System.Windows.Forms.TextBox();
            this.calculateQpButton = new System.Windows.Forms.Button();
            this.partyQpLabel = new System.Windows.Forms.Label();
            this.partyQpTextBox = new System.Windows.Forms.TextBox();
            this.partyInfo2Label = new System.Windows.Forms.Label();
            this.partyInfo2TextBox = new System.Windows.Forms.TextBox();
            this.showInfo1Button = new System.Windows.Forms.Button();
            this.showInfo2Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(470, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Партия";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(171, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Класс 1-го уровня";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(708, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Класс 2-го уровня";
            // 
            // partyNameLabel
            // 
            this.partyNameLabel.AutoSize = true;
            this.partyNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.partyNameLabel.Location = new System.Drawing.Point(44, 146);
            this.partyNameLabel.Name = "partyNameLabel";
            this.partyNameLabel.Size = new System.Drawing.Size(141, 20);
            this.partyNameLabel.TabIndex = 3;
            this.partyNameLabel.Text = "Название партии";
            // 
            // partySizeLabel
            // 
            this.partySizeLabel.AutoSize = true;
            this.partySizeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.partySizeLabel.Location = new System.Drawing.Point(44, 184);
            this.partySizeLabel.Name = "partySizeLabel";
            this.partySizeLabel.Size = new System.Drawing.Size(215, 20);
            this.partySizeLabel.TabIndex = 4;
            this.partySizeLabel.Text = "Численность (тыс. членов)";
            // 
            // partyPercentLabel
            // 
            this.partyPercentLabel.AutoSize = true;
            this.partyPercentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.partyPercentLabel.Location = new System.Drawing.Point(44, 219);
            this.partyPercentLabel.Name = "partyPercentLabel";
            this.partyPercentLabel.Size = new System.Drawing.Size(179, 40);
            this.partyPercentLabel.TabIndex = 5;
            this.partyPercentLabel.Text = "Процент голосов\nна последних выборах";
            // 
            // partyQLabel
            // 
            this.partyQLabel.AutoSize = true;
            this.partyQLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.partyQLabel.Location = new System.Drawing.Point(49, 330);
            this.partyQLabel.Name = "partyQLabel";
            this.partyQLabel.Size = new System.Drawing.Size(34, 20);
            this.partyQLabel.TabIndex = 6;
            this.partyQLabel.Text = "Q =";
            // 
            // partyNameTextBox
            // 
            this.partyNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.partyNameTextBox.Location = new System.Drawing.Point(191, 143);
            this.partyNameTextBox.Name = "partyNameTextBox";
            this.partyNameTextBox.Size = new System.Drawing.Size(283, 26);
            this.partyNameTextBox.TabIndex = 7;
            // 
            // partySizeTextBox
            // 
            this.partySizeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.partySizeTextBox.Location = new System.Drawing.Point(265, 181);
            this.partySizeTextBox.Name = "partySizeTextBox";
            this.partySizeTextBox.Size = new System.Drawing.Size(209, 26);
            this.partySizeTextBox.TabIndex = 8;
            // 
            // partyPercentOfVotesTextBox
            // 
            this.partyPercentOfVotesTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.partyPercentOfVotesTextBox.Location = new System.Drawing.Point(229, 233);
            this.partyPercentOfVotesTextBox.Name = "partyPercentOfVotesTextBox";
            this.partyPercentOfVotesTextBox.Size = new System.Drawing.Size(245, 26);
            this.partyPercentOfVotesTextBox.TabIndex = 9;
            // 
            // partyQTextBox
            // 
            this.partyQTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.partyQTextBox.Location = new System.Drawing.Point(89, 327);
            this.partyQTextBox.Name = "partyQTextBox";
            this.partyQTextBox.ReadOnly = true;
            this.partyQTextBox.Size = new System.Drawing.Size(385, 26);
            this.partyQTextBox.TabIndex = 10;
            // 
            // calculateQButton
            // 
            this.calculateQButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.calculateQButton.Location = new System.Drawing.Point(48, 276);
            this.calculateQButton.Name = "calculateQButton";
            this.calculateQButton.Size = new System.Drawing.Size(426, 35);
            this.calculateQButton.TabIndex = 11;
            this.calculateQButton.Text = "Посчитать Q";
            this.calculateQButton.UseVisualStyleBackColor = true;
            this.calculateQButton.Click += new System.EventHandler(this.calculateQButton_Click);
            // 
            // partyInfo1Label
            // 
            this.partyInfo1Label.AutoSize = true;
            this.partyInfo1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.partyInfo1Label.Location = new System.Drawing.Point(121, 378);
            this.partyInfo1Label.Name = "partyInfo1Label";
            this.partyInfo1Label.Size = new System.Drawing.Size(274, 20);
            this.partyInfo1Label.TabIndex = 12;
            this.partyInfo1Label.Text = "Информация о партии 1-го уровня:";
            // 
            // partyInfo1TextBox
            // 
            this.partyInfo1TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.partyInfo1TextBox.Location = new System.Drawing.Point(48, 420);
            this.partyInfo1TextBox.Multiline = true;
            this.partyInfo1TextBox.Name = "partyInfo1TextBox";
            this.partyInfo1TextBox.Size = new System.Drawing.Size(426, 129);
            this.partyInfo1TextBox.TabIndex = 13;
            this.partyInfo1TextBox.Text = "Для работы с функциями класса 1-го уровня заполните поля класса 1-го уровня";
            // 
            // partySizeLastYearLabel
            // 
            this.partySizeLastYearLabel.AutoSize = true;
            this.partySizeLastYearLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.partySizeLastYearLabel.Location = new System.Drawing.Point(538, 143);
            this.partySizeLastYearLabel.Name = "partySizeLastYearLabel";
            this.partySizeLastYearLabel.Size = new System.Drawing.Size(222, 40);
            this.partySizeLastYearLabel.TabIndex = 14;
            this.partySizeLastYearLabel.Text = "Численность в\nпрошлом году (тыс. членов)";
            // 
            // partySizeLastYearTextBox
            // 
            this.partySizeLastYearTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.partySizeLastYearTextBox.Location = new System.Drawing.Point(766, 149);
            this.partySizeLastYearTextBox.Name = "partySizeLastYearTextBox";
            this.partySizeLastYearTextBox.Size = new System.Drawing.Size(204, 26);
            this.partySizeLastYearTextBox.TabIndex = 15;
            // 
            // calculateQpButton
            // 
            this.calculateQpButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.calculateQpButton.Location = new System.Drawing.Point(542, 276);
            this.calculateQpButton.Name = "calculateQpButton";
            this.calculateQpButton.Size = new System.Drawing.Size(428, 35);
            this.calculateQpButton.TabIndex = 16;
            this.calculateQpButton.Text = "Посчитать Qp";
            this.calculateQpButton.UseVisualStyleBackColor = true;
            this.calculateQpButton.Click += new System.EventHandler(this.calculateQpButton_Click);
            // 
            // partyQpLabel
            // 
            this.partyQpLabel.AutoSize = true;
            this.partyQpLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.partyQpLabel.Location = new System.Drawing.Point(542, 327);
            this.partyQpLabel.Name = "partyQpLabel";
            this.partyQpLabel.Size = new System.Drawing.Size(43, 20);
            this.partyQpLabel.TabIndex = 17;
            this.partyQpLabel.Text = "Qp =";
            // 
            // partyQpTextBox
            // 
            this.partyQpTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.partyQpTextBox.Location = new System.Drawing.Point(591, 324);
            this.partyQpTextBox.Name = "partyQpTextBox";
            this.partyQpTextBox.ReadOnly = true;
            this.partyQpTextBox.Size = new System.Drawing.Size(378, 26);
            this.partyQpTextBox.TabIndex = 18;
            // 
            // partyInfo2Label
            // 
            this.partyInfo2Label.AutoSize = true;
            this.partyInfo2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.partyInfo2Label.Location = new System.Drawing.Point(621, 378);
            this.partyInfo2Label.Name = "partyInfo2Label";
            this.partyInfo2Label.Size = new System.Drawing.Size(274, 20);
            this.partyInfo2Label.TabIndex = 19;
            this.partyInfo2Label.Text = "Информация о партии 2-го уровня:";
            // 
            // partyInfo2TextBox
            // 
            this.partyInfo2TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.partyInfo2TextBox.Location = new System.Drawing.Point(542, 420);
            this.partyInfo2TextBox.Multiline = true;
            this.partyInfo2TextBox.Name = "partyInfo2TextBox";
            this.partyInfo2TextBox.Size = new System.Drawing.Size(427, 129);
            this.partyInfo2TextBox.TabIndex = 20;
            this.partyInfo2TextBox.Text = "Для работы с функциями класса 2-го уровня заполните поля классов 1-го и 2-го уров" +
    "ня";
            // 
            // showInfo1Button
            // 
            this.showInfo1Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.showInfo1Button.Location = new System.Drawing.Point(48, 556);
            this.showInfo1Button.Name = "showInfo1Button";
            this.showInfo1Button.Size = new System.Drawing.Size(426, 32);
            this.showInfo1Button.TabIndex = 21;
            this.showInfo1Button.Text = "Показать информацию о партии 1-го уровня";
            this.showInfo1Button.UseVisualStyleBackColor = true;
            this.showInfo1Button.Click += new System.EventHandler(this.showInfo1Button_Click);
            // 
            // showInfo2Button
            // 
            this.showInfo2Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.showInfo2Button.Location = new System.Drawing.Point(542, 555);
            this.showInfo2Button.Name = "showInfo2Button";
            this.showInfo2Button.Size = new System.Drawing.Size(427, 33);
            this.showInfo2Button.TabIndex = 22;
            this.showInfo2Button.Text = "Показать информацию о партии 2-го уровня";
            this.showInfo2Button.UseVisualStyleBackColor = true;
            this.showInfo2Button.Click += new System.EventHandler(this.showInfo2Button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 612);
            this.Controls.Add(this.showInfo2Button);
            this.Controls.Add(this.showInfo1Button);
            this.Controls.Add(this.partyInfo2TextBox);
            this.Controls.Add(this.partyInfo2Label);
            this.Controls.Add(this.partyQpTextBox);
            this.Controls.Add(this.partyQpLabel);
            this.Controls.Add(this.calculateQpButton);
            this.Controls.Add(this.partySizeLastYearTextBox);
            this.Controls.Add(this.partySizeLastYearLabel);
            this.Controls.Add(this.partyInfo1TextBox);
            this.Controls.Add(this.partyInfo1Label);
            this.Controls.Add(this.calculateQButton);
            this.Controls.Add(this.partyQTextBox);
            this.Controls.Add(this.partyPercentOfVotesTextBox);
            this.Controls.Add(this.partySizeTextBox);
            this.Controls.Add(this.partyNameTextBox);
            this.Controls.Add(this.partyQLabel);
            this.Controls.Add(this.partyPercentLabel);
            this.Controls.Add(this.partySizeLabel);
            this.Controls.Add(this.partyNameLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Партия";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label partyNameLabel;
        private System.Windows.Forms.Label partySizeLabel;
        private System.Windows.Forms.Label partyPercentLabel;
        private System.Windows.Forms.Label partyQLabel;
        private System.Windows.Forms.TextBox partyNameTextBox;
        private System.Windows.Forms.TextBox partySizeTextBox;
        private System.Windows.Forms.TextBox partyPercentOfVotesTextBox;
        private System.Windows.Forms.TextBox partyQTextBox;
        private System.Windows.Forms.Button calculateQButton;
        private System.Windows.Forms.Label partyInfo1Label;
        private System.Windows.Forms.TextBox partyInfo1TextBox;
        private System.Windows.Forms.Label partySizeLastYearLabel;
        private System.Windows.Forms.TextBox partySizeLastYearTextBox;
        private System.Windows.Forms.Button calculateQpButton;
        private System.Windows.Forms.Label partyQpLabel;
        private System.Windows.Forms.TextBox partyQpTextBox;
        private System.Windows.Forms.Label partyInfo2Label;
        private System.Windows.Forms.TextBox partyInfo2TextBox;
        private System.Windows.Forms.Button showInfo1Button;
        private System.Windows.Forms.Button showInfo2Button;
    }
}

