﻿[System.Serializable]
public struct IntVector2 {
	public int x, z;

	public IntVector2(int x, int z){
		this.x = x;
		this.z = z;
	}

    public int X 
    {
        get { return x; }
        set { x = value; }
    }

    public int Z
    {
        get { return Z; }
        set { Z = value; }
    }

	//ridefinisco l'operatore + e il risultato della somma è in a, ma questo non crea problemi in quanto le
	//strutture vengono passate per valore e non per riferimento
	public static IntVector2 operator + (IntVector2 a, IntVector2 b){
		a.x += b.x;
		a.z += b.z;
		return a;
	}

    public override string ToString()
    {
        return "x: " + x + ",z: " + z;
    }
}
