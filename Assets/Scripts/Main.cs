using UnityEngine;
using System.Collections;

public class Main : MonoBehaviour {

    public GameObject redPrefab;
    public GameObject whitePrefab;

    public class State
    {
        private Piece[,] pieces;
        private State(GameObject redPrefab, GameObject whitePrefab)
        {
            pieces = new Piece[Borders.Str, Borders.Col];
            for (int i = 0; i < Borders.Str; i++)
                for (int j = 0; j < Borders.Col; j++)
                    if (i < 3)
                    {

                        GameObject instance = Instantiate(redPrefab, new Vector3(3.5f - i, ,0.525f)) as GameObject;
                        pieces[i, j] =
                    }
                    else
                        if (i < 5)
                        pieces[i, j] = PieceState.Empty;
                    else
                        pieces[i, j] = PieceState.White;
        }
        private int assess()
        {
            return 0;
        }
        private State getStates()
        {
            return new State();
        }

        public static State CreateInitialState()
        {
            return new State();
        }

        /*public Turn getBestTurn()
        {

        }*/

        public void makeTurn(Turn turn)
        {

        }

        public State getResultOfTurn(Turn turn)
        {
            State newState = this;
            newState.makeTurn(turn);
            return newState;
        }

        public ResultOfTheMatch haveSbWon()
        {
            return ResultOfTheMatch.Draw;
        }
    }

    public enum PieceState { Empty, Red, White, WhiteKing, RedKing }

    public class Piece
    {
        private GameObject referenceToObject;
        private PieceState pieceState;

        public Piece(GameObject _ref, PieceState pS)
        {
            referenceToObject = _ref;
            pieceState = pS;
        }

        public GameObject ReferenceToObject
        {
            get
            {
                return referenceToObject;
            }

            set
            {
                referenceToObject = value;
            }
        }

        public PieceState PieceState
        {
            get
            {
                return pieceState;
            }

            set
            {
                pieceState = value;
            }
        }
    }

    public enum WhoTurns { Red, White }

    public enum ResultOfTheMatch { Unknown, Red, White, Draw }

    public class Borders
    {
        public static int Str = 8;
        public static int Col = 4;
    }





    public class Turn
    {
        private Pos initialPos;
        private Pos endPos;

        Turn(Pos initialPos, Pos endPos)
        {
            this.initialPos = initialPos;
            this.endPos = endPos;
        }
        public Pos InitialPos
        {
            get
            {
                return initialPos;
            }
        }

        public Pos EndPos
        {
            get
            {
                return endPos;
            }
        }
    }

    public class Pos
    {
        Pos(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
        private int x;
        private int y;

        public int X
        {
            get
            {
                return x;
            }

            set
            {
                x = value;
            }
        }

        public int Y
        {
            get
            {
                return y;
            }

            set
            {
                y = value;
            }
        }

        public Vector3 getRealPosition()
        {
            return new Vector3(0, 0, 0);
        }

    }





    State currentState;
	// Use this for initialization
	void Start () {
        currentState = State.CreateInitialState();
	}
	
	// Update is called once per frame
	void Update () {
	    
	}
}


