 private delegate void moveBd(PictureBox btn);
        
        void movePictureBoxR(PictureBox btn)
        {
            int x = btn.Location.X;
            int y = btn.Location.Y;
            btn.Location = new Point(x + 1, y);
        }
        
        void movePictureBoxL(PictureBox btn)
        {
            int x = btn.Location.X;
            int y = btn.Location.Y;
            btn.Location = new Point(x - 1, y);
        }
        
        void movePictureBoxU(PictureBox btn)
        {
            int x = btn.Location.X;
            int y = btn.Location.Y;
            btn.Location = new Point(x , y-1);
        }
        
        void movePictureBoxD(PictureBox btn)
        {
            int x = btn.Location.X;
            int y = btn.Location.Y;
            btn.Location = new Point(x, y + 1);
        }

        private void Go()
        {
           PictureBox b1=pictureBox7,b2=pictureBox1; 
           if(b1.Location.X<b2.Location.X )
            while ((b1.Location.X + b1.Size.Width) < b2.Location.X + b2.Size.Width)
            {
                Invoke(new moveBd(movePictureBoxR), b1);
                Thread.Sleep(1);
            }
           else
               while ((b1.Location.X + b1.Size.Width) > b2.Location.X + b2.Size.Width)
               {
                   Invoke(new moveBd(movePictureBoxL), b1);
                   Thread.Sleep(1);
               }
           if (b1.Location.Y > b2.Location.Y)
            while ((b1.Location.Y + b1.Size.Width) > b2.Location.Y + b2.Size.Width)
            {
                Invoke(new moveBd(movePictureBoxU), b1);
                Thread.Sleep(1);
            }        
           else
               while ((b1.Location.Y + b1.Size.Width) < b2.Location.Y + b2.Size.Width)
               {
                   Invoke(new moveBd(movePictureBoxD), b1);
                   Thread.Sleep(1);
               }
        }
