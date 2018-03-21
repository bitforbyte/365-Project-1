class Instruction : IInstruction
{
	string mStr;
	string Str
	{
		get { return mStr; }
		set { mStr = value; }
	}

	uint mEncoded;
	uint Encoded
	{
		get { return mEncoded; }
	}
}
