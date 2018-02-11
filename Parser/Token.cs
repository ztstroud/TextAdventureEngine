using System;

namespace engine
{
    /// <summary>
    /// A word or symbol in a sentence.
    /// </summary>
    public class Token
    {
        /// <summary>
        /// The string value of this token.
        /// </summary>
        public string Value { get; internal set; }

        /// <summary>
        /// The type of this token.
        /// </summary>
        public TokenType Type { get; internal set; }

        /// <summary>
        /// Constructs a new token with the given value and type.
        /// 
        /// A token cannot have a null value, and if null is passed an
        /// ArgumentNullException will be trhown.
        /// </summary>
        /// 
        /// <param name="value">the value of the token</param>
        /// <param name="type">the type of the token</param>
        public Token(string value, TokenType type)
        {
            Value = value ?? throw new ArgumentNullException("Token cannot have null value");
            Type  = type;
        }

        /// <summary>
        /// Constructs a new token with the given value and a default type of
        /// None.
        /// 
        /// A token cannot have a null value, and if null is passed an
        /// ArgumentNullException will be trhown.
        /// </summary>
        /// 
        /// <param name="value">the value of the token</param>
        public Token(string value)
        {
            Value = value ?? throw new ArgumentNullException("Token cannot have null value");
            Type  = TokenType.None;
        }

        /// <summary>
        /// Creates a string representation of this token.
        /// </summary>
        /// 
        /// <returns>a string representation of this token</returns>
        public override string ToString()
        {
            return $"{Value} [{Type}]";
        }
    }

    /// <summary>
    /// Describes the purpose of a token in a sentence.
    /// </summary>
    public enum TokenType
    {
        None,
        Verb,
        Preposition,
        Article,
        Adjective,
        Noun,
    }
}
