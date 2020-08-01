using System; 


namespace internalAccessModifier{

    class Program{
        static void Main(string[] args)
        {
            Complex c = new Complex();
            text n = new text();
            c.show();
            n.hide();
        }
    }
    class text{
        public void hide()
        {
           Complex c = new Complex();
           c.show();
        }
    }
}

