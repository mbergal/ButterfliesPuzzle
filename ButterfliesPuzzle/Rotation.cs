namespace ButterfliesPuzzle
    {
    public class Rotation 
        {
        public static readonly Rotation Rotation90  = new Rotation( 0, 1, -1, 0 );

        public int P1 { get; set; }
        public int P2 { get; set; }
        public int P3 { get; set; }
        public int P4 { get; set; }

        private Rotation( int p1, int p2, int p3, int p4 )
            {
            P1 = p1;
            P2 = p2;
            P3 = p3;
            P4 = p4;              
            }
        }
    }