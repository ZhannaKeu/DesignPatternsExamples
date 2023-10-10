using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsExamples.Command_pattern
{
    public class PasteCommand:Command
    {
        Document document;
        int position;
        string text;

        public PasteCommand(Document document, int position, string text)
        {
            this.document = document;
            this.position = position;
            this.text = text;
        }
        public new void Execute()
        {
            document.InsertText(position, text);
        }
        public new void Unexecute()
        {
            document.DeleteText(position, text.Length);
        }
        public new bool IsReversible()
        {
            return true;
        }
    }
}
