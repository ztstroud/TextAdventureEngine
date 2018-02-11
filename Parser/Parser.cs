using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace engine
{
    /// <summary>
    /// Provides utils for parsing text into tokens.
    /// </summary>
    public class Parser
    {
        /// <summary>
        /// Turns a string into a list of tokens. All tokens will have a type of
        /// None.
        /// 
        /// Valid tokens are:
        ///     word        - [a-z-]+
        ///     punctuation - [.,!?]
        ///     
        /// No text will be excluded from the strings. All other non-whitespace
        /// characters will be put placed into tokens as well.
        /// </summary>
        /// 
        /// <param name="input">the string to lex</param>
        /// 
        /// <returns>the lexed tokens</returns>
        public List<Token> Lex(string input)
        {
            List<Token> tokens = new List<Token>();

            // uses a regular expression to break the input into tokens
            foreach(Match match in Regex.Matches(input, @"[a-z-]+|[.,!?]|[^\s]+"))
                tokens.Add(new Token(match.Value));

            return tokens;
        }

        /// <summary>
        /// Normalizes a string, making it compatible with the parsing engine.
        /// </summary>
        /// 
        /// <param name="input">the string to normalize</param>
        /// 
        /// <returns>the normalized string</returns>
        public static string Normalize(string input)
        {
            return input.Trim().ToLower();
        }
    }
}
