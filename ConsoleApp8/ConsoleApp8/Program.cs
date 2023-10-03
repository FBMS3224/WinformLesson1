

using System.Windows.Forms;

Form window = new Form();
window.Text = "Lesson 1";

Button button = new Button();
button.Text = "Hello World";
button.Location = new Point(100, 250);



//button.Click += Button_Click;

//void Button_Click(object? sender, EventArgs e)
//{
//    Console.WriteLine("Hello World");

//    var mouse = e as MouseEventArgs;
//    Console.WriteLine(mouse.X);
//    Console.WriteLine(mouse.Y);
//}

//button.MouseClick += (s,e)=> { Console.WriteLine("Hakuna Matata"); };

//void MyCLickFunction(object? s, MouseEventArgs e)
//{
    
//}


window.Controls.Add(button);
// window.Show();
window.ShowDialog();






