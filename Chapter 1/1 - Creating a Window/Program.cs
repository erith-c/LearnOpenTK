﻿namespace LearnOpenGL_TK
{
    public static class Program
    {
        private static void Main(string[] args)
        {
            // To create a new window, create a class that extends GameWindow, then call Run() on it.
            // Run takes a double, which is how many frames per second it should strive to reach.
            // You can leave that out and it'll just update as fast as the hardware will allow it.
            using (var game = new Window(800, 600, "LearnOpenTK - Creating a Window"))
                game.Run(60.0);

            // And that's it! That's all it takes to create a window with OpenTK.
        }
    }
}
