using System;
using System.Collections.Generic;
using System.Text;
using _JMS;

namespace JMS_Explorer.AppendedJMSDB
{
    public enum version {
        halo1 = 8200,
        halo2 = 8210
    }

    public class databaseFile {
        public databaseFile(version ver) { 
        


        }
    
    
    }
    struct iVec3 {
        int x;
        int y;
        int z;
    }

    class aJMSdb //aJMS for "Appended JMS Database file
    {
        public int version; //start with .01
                            //list of material names?
                            //what those materials can connect to
                            //or index the triangles(?)
        public struct attachInfo { 
        
        
        
        }

    }
    struct PieceID {
        string name;
    }


    class Piece
    {
	    PieceID id;		// not instance-dependent;
		    // reference to database
        //Material id's or
        //Triangles with mat id's
        //ProductionLevel type;
        
    }

    class JNode
    {
	    Piece piece; // the piece this node represents
        iVec3 location;
	    JNode[] neighbors; // the connections of this note
		         // attachment position indices correspond to the indices in this array
	    // A neighbor node B at index 0 in this array implies that B.piece is attached to this node's piece at attachment point 0
    }
}
