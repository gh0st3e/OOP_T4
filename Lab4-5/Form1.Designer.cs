
namespace Lab4
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.AF1_Pattern = new System.Windows.Forms.Button();
            this.AbstractFactory = new System.Windows.Forms.Label();
            this.AF2 = new System.Windows.Forms.Button();
            this.Builder = new System.Windows.Forms.Label();
            this.Builder1 = new System.Windows.Forms.Button();
            this.Builder2 = new System.Windows.Forms.Button();
            this.Singleton = new System.Windows.Forms.Label();
            this.Singlton = new System.Windows.Forms.Button();
            this.FieldForProc = new System.Windows.Forms.TextBox();
            this.AddNewItem = new System.Windows.Forms.Button();
            this.Prototype = new System.Windows.Forms.Label();
            this.Clone = new System.Windows.Forms.Button();
            this.VidMem = new System.Windows.Forms.TextBox();
            this.DirectX = new System.Windows.Forms.TextBox();
            this.CreateVidFromBuilder = new System.Windows.Forms.Button();
            this.Видеопамять = new System.Windows.Forms.Label();
            this.DirectXVer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AF1_Pattern
            // 
            this.AF1_Pattern.Font = new System.Drawing.Font("Cooper Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AF1_Pattern.Location = new System.Drawing.Point(23, 48);
            this.AF1_Pattern.Name = "AF1_Pattern";
            this.AF1_Pattern.Size = new System.Drawing.Size(149, 64);
            this.AF1_Pattern.TabIndex = 0;
            this.AF1_Pattern.Text = "Abstract Factory old and low";
            this.AF1_Pattern.UseVisualStyleBackColor = true;
            this.AF1_Pattern.Click += new System.EventHandler(this.AF_Pattern_Click);
            // 
            // AbstractFactory
            // 
            this.AbstractFactory.AutoSize = true;
            this.AbstractFactory.Font = new System.Drawing.Font("Cooper Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AbstractFactory.Location = new System.Drawing.Point(42, 20);
            this.AbstractFactory.Name = "AbstractFactory";
            this.AbstractFactory.Size = new System.Drawing.Size(112, 14);
            this.AbstractFactory.TabIndex = 1;
            this.AbstractFactory.Text = "Abstract Factory";
            // 
            // AF2
            // 
            this.AF2.Font = new System.Drawing.Font("Cooper Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AF2.Location = new System.Drawing.Point(23, 118);
            this.AF2.Name = "AF2";
            this.AF2.Size = new System.Drawing.Size(149, 57);
            this.AF2.TabIndex = 2;
            this.AF2.Text = "Abstract Factory modern and high\r\n";
            this.AF2.UseVisualStyleBackColor = true;
            this.AF2.Click += new System.EventHandler(this.AF2_Click);
            // 
            // Builder
            // 
            this.Builder.AutoSize = true;
            this.Builder.Font = new System.Drawing.Font("Cooper Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Builder.Location = new System.Drawing.Point(241, 20);
            this.Builder.Name = "Builder";
            this.Builder.Size = new System.Drawing.Size(52, 14);
            this.Builder.TabIndex = 3;
            this.Builder.Text = "Builder";
            // 
            // Builder1
            // 
            this.Builder1.Font = new System.Drawing.Font("Cooper Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Builder1.Location = new System.Drawing.Point(191, 48);
            this.Builder1.Name = "Builder1";
            this.Builder1.Size = new System.Drawing.Size(149, 64);
            this.Builder1.TabIndex = 4;
            this.Builder1.Text = "Buillder high video";
            this.Builder1.UseVisualStyleBackColor = true;
            this.Builder1.Click += new System.EventHandler(this.Builder1_Click);
            // 
            // Builder2
            // 
            this.Builder2.Font = new System.Drawing.Font("Cooper Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Builder2.Location = new System.Drawing.Point(191, 118);
            this.Builder2.Name = "Builder2";
            this.Builder2.Size = new System.Drawing.Size(149, 57);
            this.Builder2.TabIndex = 5;
            this.Builder2.Text = "Buillder low video";
            this.Builder2.UseVisualStyleBackColor = true;
            this.Builder2.Click += new System.EventHandler(this.Builder2_Click);
            // 
            // Singleton
            // 
            this.Singleton.AutoSize = true;
            this.Singleton.Font = new System.Drawing.Font("Cooper Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Singleton.Location = new System.Drawing.Point(398, 20);
            this.Singleton.Name = "Singleton";
            this.Singleton.Size = new System.Drawing.Size(69, 14);
            this.Singleton.TabIndex = 6;
            this.Singleton.Text = "Singletom";
            // 
            // Singlton
            // 
            this.Singlton.Font = new System.Drawing.Font("Cooper Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Singlton.Location = new System.Drawing.Point(358, 48);
            this.Singlton.Name = "Singlton";
            this.Singlton.Size = new System.Drawing.Size(149, 64);
            this.Singlton.TabIndex = 7;
            this.Singlton.Text = "Singleton";
            this.Singlton.UseVisualStyleBackColor = true;
            this.Singlton.Click += new System.EventHandler(this.Singlton_Click);
            // 
            // FieldForProc
            // 
            this.FieldForProc.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FieldForProc.Location = new System.Drawing.Point(23, 243);
            this.FieldForProc.Multiline = true;
            this.FieldForProc.Name = "FieldForProc";
            this.FieldForProc.Size = new System.Drawing.Size(970, 284);
            this.FieldForProc.TabIndex = 8;
            // 
            // AddNewItem
            // 
            this.AddNewItem.Font = new System.Drawing.Font("Cooper Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddNewItem.Location = new System.Drawing.Point(23, 213);
            this.AddNewItem.Name = "AddNewItem";
            this.AddNewItem.Size = new System.Drawing.Size(149, 24);
            this.AddNewItem.TabIndex = 9;
            this.AddNewItem.Text = "Add";
            this.AddNewItem.UseVisualStyleBackColor = true;
            this.AddNewItem.Click += new System.EventHandler(this.AddNewItem_Click);
            // 
            // Prototype
            // 
            this.Prototype.AutoSize = true;
            this.Prototype.Font = new System.Drawing.Font("Cooper Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Prototype.Location = new System.Drawing.Point(570, 20);
            this.Prototype.Name = "Prototype";
            this.Prototype.Size = new System.Drawing.Size(68, 14);
            this.Prototype.TabIndex = 10;
            this.Prototype.Text = "Prototype";
            // 
            // Clone
            // 
            this.Clone.Font = new System.Drawing.Font("Cooper Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Clone.Location = new System.Drawing.Point(529, 48);
            this.Clone.Name = "Clone";
            this.Clone.Size = new System.Drawing.Size(149, 64);
            this.Clone.TabIndex = 11;
            this.Clone.Text = "Clone";
            this.Clone.UseVisualStyleBackColor = true;
            this.Clone.Click += new System.EventHandler(this.Clone_Click);
            // 
            // VidMem
            // 
            this.VidMem.Location = new System.Drawing.Point(790, 48);
            this.VidMem.Name = "VidMem";
            this.VidMem.Size = new System.Drawing.Size(138, 23);
            this.VidMem.TabIndex = 12;
            // 
            // DirectX
            // 
            this.DirectX.Location = new System.Drawing.Point(790, 77);
            this.DirectX.Name = "DirectX";
            this.DirectX.Size = new System.Drawing.Size(138, 23);
            this.DirectX.TabIndex = 14;
            // 
            // CreateVidFromBuilder
            // 
            this.CreateVidFromBuilder.Location = new System.Drawing.Point(790, 118);
            this.CreateVidFromBuilder.Name = "CreateVidFromBuilder";
            this.CreateVidFromBuilder.Size = new System.Drawing.Size(138, 23);
            this.CreateVidFromBuilder.TabIndex = 15;
            this.CreateVidFromBuilder.Text = "Создать видеокарту";
            this.CreateVidFromBuilder.UseVisualStyleBackColor = true;
            this.CreateVidFromBuilder.Click += new System.EventHandler(this.CreateVidFromBuilder_Click);
            // 
            // Видеопамять
            // 
            this.Видеопамять.AutoSize = true;
            this.Видеопамять.Location = new System.Drawing.Point(705, 51);
            this.Видеопамять.Name = "Видеопамять";
            this.Видеопамять.Size = new System.Drawing.Size(79, 15);
            this.Видеопамять.TabIndex = 16;
            this.Видеопамять.Text = "Видеопамять";
            // 
            // DirectXVer
            // 
            this.DirectXVer.AutoSize = true;
            this.DirectXVer.Location = new System.Drawing.Point(739, 85);
            this.DirectXVer.Name = "DirectXVer";
            this.DirectXVer.Size = new System.Drawing.Size(45, 15);
            this.DirectXVer.TabIndex = 17;
            this.DirectXVer.Text = "DirectX";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 567);
            this.Controls.Add(this.DirectXVer);
            this.Controls.Add(this.Видеопамять);
            this.Controls.Add(this.CreateVidFromBuilder);
            this.Controls.Add(this.DirectX);
            this.Controls.Add(this.VidMem);
            this.Controls.Add(this.Clone);
            this.Controls.Add(this.Prototype);
            this.Controls.Add(this.AddNewItem);
            this.Controls.Add(this.FieldForProc);
            this.Controls.Add(this.Singlton);
            this.Controls.Add(this.Singleton);
            this.Controls.Add(this.Builder2);
            this.Controls.Add(this.Builder1);
            this.Controls.Add(this.Builder);
            this.Controls.Add(this.AF2);
            this.Controls.Add(this.AbstractFactory);
            this.Controls.Add(this.AF1_Pattern);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AF1_Pattern;
        private System.Windows.Forms.Label AbstractFactory;
        private System.Windows.Forms.Button AF2;
        private System.Windows.Forms.Label Builder;
        private System.Windows.Forms.Button Builder1;
        private System.Windows.Forms.Button Builder2;
        private System.Windows.Forms.Label Singleton;
        private System.Windows.Forms.Button Singlton;
        private System.Windows.Forms.TextBox FieldForProc;
        private System.Windows.Forms.Button AddNewItem;
        private System.Windows.Forms.Label Prototype;
        private System.Windows.Forms.Button Clone;
        private System.Windows.Forms.TextBox VidMem;
        private System.Windows.Forms.TextBox DirectX;
        private System.Windows.Forms.Button CreateVidFromBuilder;
        private System.Windows.Forms.Label Видеопамять;
        private System.Windows.Forms.Label DirectXVer;
    }
}

