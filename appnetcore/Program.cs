using System;

namespace projetos {
    class Program {
        static void Main (string[] args) {
            if (args == null) {
                Console.WriteLine ("Ola Mundo !");
            } else {
                Console.WriteLine (args[0].ToString ());
            }
        }
    }
}