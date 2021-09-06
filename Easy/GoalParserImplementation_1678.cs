public class GoalParserImplementation_1678{
    public string Interpret(string command) {
        int index = 0;
        string s = "";
        
        while(index < command.Length)
        {
            if(command[index] == 'G')
            {
                s += "G";
                index++;
            }
            else
            {
                if(command[index + 1] == ')')
                {
                    index += 2;
                    s += "o";
                }
                else
                {
                    index += 4;
                    s += "al";
                }
            }
        }
        return s;
    }
}