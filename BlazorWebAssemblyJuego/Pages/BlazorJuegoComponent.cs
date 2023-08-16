using BlazorWebAssemblyJuego.Models;

namespace BlazorWebAssemblyJuego.Pages
{
    public partial class BlazorJuegoComponent
    {
        int score = 0;
        int currentTime = 60;
        int hitPosition = 0;
        int hitPosition1 = 100;
        int hitPosition2 = 100;
        string message = "";
        int gameSpeed = 500;
        bool isGameRunning = true;

        int[] Letras = new int[7];

        public List<SquareModel> Squares { get; set; } =
            new List<SquareModel>();

        public BlazorJuegoComponent() {
            for(int i = 0; i <49 ; i++)
            {
                Squares.Add(new SquareModel() { Id  = i });
            }
        
        }
    }
}
