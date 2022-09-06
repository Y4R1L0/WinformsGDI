using System;
using System.Drawing;

namespace Maze
{
    class MazeObject
    {
        public enum MazeObjectType { HALL, WALL, MEDAL, ENEMY, MEDKIT, CHAR
        };

        public Bitmap[] images = {
            new Bitmap(@"C:\2\hall.png"),
            new Bitmap(@"C:\2\wall.png"),
            new Bitmap(@"C:\2\medal.png"),
            new Bitmap(@"C:\2\enemy.png"),
            new Bitmap(@"C:\2\MedKit.png"),
            new Bitmap(@"C:\2\player.png")};

        public MazeObjectType type;
        public int width;
        public int height;
        public Image texture;

        public MazeObject(MazeObjectType type)
        {
            this.type = type;
            width = 16;
            height = 16;
            texture = images[(int)type];
        }

    }
}
