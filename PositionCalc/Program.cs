using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PositionCalc
{

    class Camera
    {
        public double px, py, pz;
            public string name;
            public Camera(string n,double x, double y, double z)
            {
            px = x;
            py = y;
            pz = z;
            name = n;
            }
        
    }


    public class Program
    {


        static void Main(string[] args)
        {
            List<Camera> scene = new List<Camera>();
            Camera c1 = new Camera("CAM1", -3.0366, 8.9559, 3.4811);
            Camera c2 = new Camera("CAM2", -2.1342, 12.2040, -1.3186);
            Camera c3 = new Camera("CAM3", -0.3593, 7.1802, 4.7761);
            Camera c4 = new Camera("CAM4", 9.3817, 16.1474, -1.2034);

            scene.Add(c1);
            scene.Add(c2);
            scene.Add(c3);
            scene.Add(c4);

            
            for(int i=0;i<scene.Count;i++)
            {
                for (int j = 0; j < scene.Count; j++)
                {
                    if(i!=j)
                    {
                        Camera p1 = scene[i];
                        Camera p2 = scene[j];

                        Console.WriteLine("HotSpots from " + p1.name + " to  " + p2.name);
                        double p1x = p1.px;
                        double p1y = p1.py;
                        double p1z = p1.pz;


                        double p2x = p2.px;
                        double p2y = p2.py;
                        double p2z = p2.pz;

                        double dx = p2x - p1x;
                        double dy = p2y - p1y;
                        double dz = p2z - p1z;

                        double radius = Math.Sqrt(dx * dx + dy * dy + dz * dz);
                        double horizontalAngle = Math.Atan2(dy,dx);
                        double verticalAngle = Math.Acos(dz / radius);
                        Console.WriteLine(horizontalAngle + " , " + verticalAngle);
                        
                    }
                }
            }

        }
    }
}
