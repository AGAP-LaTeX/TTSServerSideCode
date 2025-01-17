﻿using LatexMath2MathML;

/**
* @author $Ahtsham Manzoor$
*/

namespace TTS_server_alap_alpha_v1
{
    public static class MathML
    {

        public static string ConvertLatextToMathMl(string latexExp)
        {
            LatexMathToMathMLConverter lmm;
            //For demo Try with following Expression
            //String latexExpression = @"$\frac{\mathrm d}{\mathrm d x} \big( k g(x \big)$";
            lmm = new LatexMathToMathMLConverter();
            return lmm.ConvertToMathMLTree(latexExpression : latexExp);

        }


    }
}
