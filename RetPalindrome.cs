public string RetPalindrome(string input)
{
	string palindrome = "";
	string rev;
	int num1;
	int num2;
	int temp;

	if(input.Length % 2 == 0)
	{
		num1 = (input.Length / 2) - 1;
		num2 = input.Length /2;
		rev = "";
	}
	else
	{
		num1 = (input.Length / 2) - 1;
		num2 = (input.Length / 2) + 1;
		rev = input[input.Length/2].ToString();
	}

	while(num1 >= 0 && num2 < input.Length && input[num1] == input[num2])
	{
		rev += input[num1];
		num1--;
		num2++;
	}

	for(int i=rev.Length-1; i>=0; i--)
	{
		palindrome += rev[i].ToString();
	}

	if(input.Length % 2 == 0)
	{
		temp = 0;
	}
	else
	{
		temp = 1;
	}

	for(;temp<rev.Length; temp++)
	{
		palindrome += rev[temp].ToString();
	}

	return palindrome;
}
