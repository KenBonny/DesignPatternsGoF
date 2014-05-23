namespace ChainOfResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            // each step in the chain (object) checks if it can process the input,
            // if not it will pass it to the next object in the chain.
            // example: an ACL will pass a request to a rule, which will decide if
            // it can handle the request and pass it on to the next rule if it can't be handled
            // used to replace numerous if/else statements or a switch
            // https://en.wikipedia.org/wiki/Chain-of-responsibility_pattern
        }
    }
}
