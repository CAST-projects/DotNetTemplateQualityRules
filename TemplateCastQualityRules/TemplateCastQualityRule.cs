using System;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Diagnostics;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Roslyn.DotNet.CastDotNetExtension;

namespace CastDotNetExtension
{
    [CastRuleChecker]
    [DiagnosticAnalyzer(LanguageNames.CSharp)]
    // [TODO#4] Enter here the description of your QR
    [RuleDescription(
        Id = "YourCustomSpecificQRNameOrId",
        Title = "Your Custom Specific QR",
        MessageFormat = "The description of your QR",
        Category = "Maintainability",
        DefaultSeverity = DiagnosticSeverity.Warning,
        // [TODO#5] set the CastProperty to the qualified name of the Cast MetaModel property 
        //          identifying the Quality Rule (in the form: "CategoryName.propertyName")
        CastProperty = "DotNetQualityRules.exampleCustomQualityRule"
    )]
    // [TODO#6] name the class according to your QR
    public class TemplateCastQualityRule : AbstractRuleChecker
    {

        /// <summary>
        /// Initialize the QR with the given context and register all the syntax nodes
        /// to listen during the visit and provide a specific callback for each one
        /// </summary>
        /// <param name="context"></param>
        public override void Init(AnalysisContext context)
        {
            // [TODO#7] register the callbacks:
            context.RegisterSyntaxNodeAction(AnalyzeIfStatement, SyntaxKind.IfStatement);
        }

        /// [TODO#8] Implement your callback function
        private void AnalyzeIfStatement(SyntaxNodeAnalysisContext nodeContext)
        {
            var ifStatement = nodeContext.Node as IfStatementSyntax;

            // [TODO#9] if a violation is found, store it using the following:

            if (ifStatement != null && ifStatement.Else == null)
            {
                AddViolation(nodeContext);
            }
        }

    }
}