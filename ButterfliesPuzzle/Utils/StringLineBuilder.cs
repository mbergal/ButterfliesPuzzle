using System.Collections.Generic;
using System.Linq;

namespace ConsoleApplication4
    {
    public class StringLineBuilder
        {
        private readonly List<string> _lines;

        public StringLineBuilder()
            {
            _lines = new List<string>();
            }

        public StringLineBuilder Append( string content )
            {
                    return Append( content.Split( '\n' ) );
            }

        public StringLineBuilder Append( string[] content )
            {
            if ( _lines.Count() < content.Length )
                {
                _lines.AddRange( Enumerable.Range( 0, content.Length - _lines.Count() ).Select( x=>"" ) );
                }

            int maxLength = _lines.Max( x=>x.Length );
            for( int i = 0; i < _lines.Count(); ++i )
                {
                _lines[i] = _lines[i].PadRight( maxLength );
                }
            for( int i = 0; i < content.Count(); ++i )
                {
                _lines[i] = _lines[i] + content[i];
                }
            return this;
            }

        public override string ToString()
            {
            return string.Join( "\n", _lines );
            }
        }
    }