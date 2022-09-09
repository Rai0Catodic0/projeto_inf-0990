public class Map{
    Elemento [,] mapa;
    public Map(Jewel[] joias, Obstacle[] obsatulos, Robot robo){
        mapa = new Elemento[10, 10];
        Console.WriteLine(joias.Length);
        for(int i = 0; i < joias.Length;i++){
            this.mapa[joias[i].x,joias[i].y] = joias[i];
        }for(int i = 0; i < obsatulos.Length;i++){
            this.mapa[obsatulos[i].x,obsatulos[i].y] = obsatulos[i];
        }
        this.mapa[robo.x,robo.y] = robo;
    }
    public void printMap(){
        for(int i=0;i<10;i++){
            for(int j=0;j<10;j++){
                if(this.mapa[i,j] == null){
                    Console.Write("--");
                }else{
                    Console.Write(mapa[i,j].ToString());
                }
                Console.Write(" ");
            }
            Console.Write("\n");
        }
    }

}