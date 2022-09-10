// See https://aka.ms/new-console-template for more information
public class JewelCollector{
    static public void Main(){
        Jewel[] joias = { new Jewel('R',1, 9),new Jewel('R', 8, 8),new  Jewel('G',9, 1),
                        new  Jewel('G',7, 6),new Jewel('B', 3, 4),new Jewel('B',2,1)
                        }; 
        Obstacle [] obstaculos = { new Obstacle('W',5,0),new Obstacle('W',5,1),new Obstacle('W',5,2),
                                   new Obstacle('W',5,3),new Obstacle('W',5,4),new Obstacle('W',5,5),
                                   new Obstacle('W',5,6),new Obstacle('t',5,9),new Obstacle('t',3,9),
                                   new Obstacle('t',8,3),new Obstacle('t',2,5),new Obstacle('t',1,4),

                                 };

        Robot robot = new Robot(0,0,joias.Length);
        Map m = new Map(joias,obstaculos,robot);
        m.printMap();
        Console.WriteLine(robot.BagToString());

        bool running = true;
  
        do {
            m.printMap();
            Console.WriteLine(robot.BagToString());
    
            Console.WriteLine("Enter the command: ");
            string command = Console.ReadLine();
 i          nt x = robo.x;
            int y = robo.y
            bool coleta = false;
            if (command.Equals("quit")) {
                running = false;
            } else if (command.Equals("w")) {
                robot.andar(robot.x,robot.y-1);
                
            } else if (command.Equals("a")) {
                robot.andar(robot.x-1,robot.y);
                
            } else if (command.Equals("s")) {
                robot.andar.(robot.x,robot.y+1);
              
            } else if (command.Equals("d")) {
                robot.andar(robot.x+1,robot.y);
            
            } else if (command.Equals("g")) {
                coleta = true;
            }
            if(coleta == true){
                //map.updateJoia()
            }else{
                m.updateRobo(robo,x,y);
            }
            
        }   
    }
}