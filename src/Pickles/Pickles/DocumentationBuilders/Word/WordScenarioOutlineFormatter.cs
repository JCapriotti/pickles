﻿#region License

/*
    Copyright [2011] [Jeffrey Cameron]

   Licensed under the Apache License, Version 2.0 (the "License");
   you may not use this file except in compliance with the License.
   You may obtain a copy of the License at

       http://www.apache.org/licenses/LICENSE-2.0

   Unless required by applicable law or agreed to in writing, software
   distributed under the License is distributed on an "AS IS" BASIS,
   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
   See the License for the specific language governing permissions and
   limitations under the License.
*/

#endregion

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DocumentFormat.OpenXml.Wordprocessing;
using Pickles.Extensions;
using Pickles.Parser;

namespace Pickles.DocumentationBuilders.Word
{
    public class WordScenarioOutlineFormatter
    {
        private readonly WordStepFormatter wordStepFormatter;
        private readonly WordTableFormatter wordTableFormatter;

        public WordScenarioOutlineFormatter(WordStepFormatter wordStepFormatter, WordTableFormatter wordTableFormatter)
        {
            this.wordStepFormatter = wordStepFormatter;
            this.wordTableFormatter = wordTableFormatter;
        }

        public void Format(Body body, ScenarioOutline scenarioOutline)
        {
            body.GenerateParagraph(scenarioOutline.Name, "Heading2");
            if (!string.IsNullOrEmpty(scenarioOutline.Description)) body.GenerateParagraph(scenarioOutline.Description, "Normal");

            foreach (var step in scenarioOutline.Steps)
            {
                this.wordStepFormatter.Format(body, step);
            }

            body.GenerateParagraph("Examples:", "Heading3");
            this.wordTableFormatter.Format(body, scenarioOutline.Example.TableArgument);
        }
    }
}
