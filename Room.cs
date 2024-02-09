
namespace Kansloos_v2
{
    public class Room
    {
        private float length;
        private float width;
        private float height;

        public Room(float length, float width, float height)
        {
            this.length = length;
            this.width = width;
            this.height = height;
        }
        public float getLength()
        {
            return this.length;
        }
        public float getWidth()
        {
            return this.width;
        }
        public float getHeight()
        {
            return this.height;
        }
        public int getVolume()
        {
            return (int) Math.Round(length * width * height);
        }
    }
}
