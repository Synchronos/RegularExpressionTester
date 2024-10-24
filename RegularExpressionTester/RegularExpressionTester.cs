using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Text.RegularExpressions;

namespace RegularExpressionTester
{
	/// <summary>
	/// Summary description for RegularExpressionTester.
	/// </summary>
	public class RegularExpressionTester : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label lblRegularExpression;
		private System.Windows.Forms.TextBox txtRegularExpression;
		private System.Windows.Forms.MenuItem menuItemCharacterEscapes;
		private System.Windows.Forms.MenuItem menuItemCharacterClasses;
		private System.Windows.Forms.MenuItem menuItemAtomicZeroWidthAssertions;
		private System.Windows.Forms.MenuItem menuItemGroupingConstructs;
		private System.Windows.Forms.MenuItem menuItemBackreferenceConstructs;
		private System.Windows.Forms.MenuItem menuItemAlternationConstructs;
		private System.Windows.Forms.MenuItem menuItemMiscellaneousConstructs;
		private System.Windows.Forms.ContextMenu contextMenuRegularExpressions;
		private System.Windows.Forms.MenuItem menuItemBellCharacter;
		private System.Windows.Forms.MenuItem menuItemWordBoundary;
		private System.Windows.Forms.MenuItem menuItemTab;
		private System.Windows.Forms.MenuItem menuItemCarriageReturn;
		private System.Windows.Forms.MenuItem menuItemVerticalTab;
		private System.Windows.Forms.MenuItem menuItemFormFeed;
		private System.Windows.Forms.MenuItem menuItemNewLine;
		private System.Windows.Forms.MenuItem menuItemEscapeCharacter;
		private System.Windows.Forms.MenuItem menuItemOctalCharacter;
		private System.Windows.Forms.MenuItem menuItemHexadecimalCharacter;
		private System.Windows.Forms.MenuItem menuItemControlCharacter;
		private System.Windows.Forms.MenuItem menuItemUnicodeCharacter;
		private System.Windows.Forms.MenuItem menuItemCharacterEscape;
		private System.Windows.Forms.MenuItem menuItemLiteralDot;
		private System.Windows.Forms.MenuItem menuItemLiteralDollar;
		private System.Windows.Forms.MenuItem menuItemLiteralCaret;
		private System.Windows.Forms.MenuItem menuItemLiteralLeftBrace;
		private System.Windows.Forms.MenuItem menuItemLiteralLeftBracket;
		private System.Windows.Forms.MenuItem menuItemLiteralVerticalBar;
		private System.Windows.Forms.MenuItem menuItemLiteralRightParen;
		private System.Windows.Forms.MenuItem menuItemLiteralAsterisk;
		private System.Windows.Forms.MenuItem menuItemLiteralPlus;
		private System.Windows.Forms.MenuItem menuItemLiteralQuestionMark;
		private System.Windows.Forms.MenuItem menuItemLiteralDash;
		private System.Windows.Forms.MenuItem menuItemLiteralNumberSign;
		private System.Windows.Forms.MenuItem menuItemLiteralLeftParen;
		private System.Windows.Forms.MenuItem menuItemAnyCharacter;
		private System.Windows.Forms.MenuItem menuItemAnyCharacterInSet;
		private System.Windows.Forms.MenuItem menuItemAnyCharacterNotInSet;
		private System.Windows.Forms.MenuItem menuItemCharacterRange;
		private System.Windows.Forms.MenuItem menuItemCharacterInNamedUnicodeBlock;
		private System.Windows.Forms.MenuItem menuItemCharacterNotInNamedUnicodeBlock;
		private System.Windows.Forms.MenuItem menuItemAnyWordCharacter;
		private System.Windows.Forms.MenuItem menuItemAnyNonWordCharacter;
		private System.Windows.Forms.MenuItem menuItemAnyWhitespaceCharacter;
		private System.Windows.Forms.MenuItem menuItemAnyNonWhitespaceCharacter;
		private System.Windows.Forms.MenuItem menuItemAnyDecimalDigit;
		private System.Windows.Forms.MenuItem menuItemAnyNonDigit;
		private System.Windows.Forms.MenuItem menuItemLineBegin;
		private System.Windows.Forms.MenuItem menuItemLineEnd;
		private System.Windows.Forms.MenuItem menuItemStringBegin;
		private System.Windows.Forms.MenuItem menuItemStrinEndNonCR;
		private System.Windows.Forms.MenuItem menuItemStringEnd;
		private System.Windows.Forms.MenuItem menuItemPreviousMatchEnd;
		private System.Windows.Forms.MenuItem menuItemWordBoundary2;
		private System.Windows.Forms.MenuItem menuItemNonWordBoundary;
		private System.Windows.Forms.MenuItem menuItemQuantifiersStarQuantifier;
		private System.Windows.Forms.MenuItem menuItemStarQuantifier;
		private System.Windows.Forms.MenuItem menuItemPlusQuantifier;
		private System.Windows.Forms.MenuItem menuItemQuestionMarkQuantifier;
		private System.Windows.Forms.MenuItem menuItemExactQuantifier;
		private System.Windows.Forms.MenuItem menuItemAtLeastQuantifier;
		private System.Windows.Forms.MenuItem menuItemAtLeastButNotMoreQuantifier;
		private System.Windows.Forms.MenuItem menuItemMatchFewestModifier;
		private System.Windows.Forms.MenuItem menuItemAutoNumberedCaptureGroup;
		private System.Windows.Forms.MenuItem menuItemNamedCaptureGroup;
		private System.Windows.Forms.MenuItem menuItemBalancingCaptureGroup;
		private System.Windows.Forms.MenuItem menuItemNonCapturingGroup;
		private System.Windows.Forms.MenuItem menuItemOptionControlGroup;
		private System.Windows.Forms.MenuItem menuItemZeroWidthPositiveLookahead;
		private System.Windows.Forms.MenuItem menuItemZeroWidthNegativeLookahead;
		private System.Windows.Forms.MenuItem menuItemZeroWidthPositiveLookbehind;
		private System.Windows.Forms.MenuItem menuItemZeroWidthNegativeLookbehind;
		private System.Windows.Forms.MenuItem menuItemNonBacktrackingSubexpression;
		private System.Windows.Forms.MenuItem menuItemBackreference;
		private System.Windows.Forms.MenuItem menuItemNamedBackreference;
		private System.Windows.Forms.MenuItem menuItemOrAlternation;
		private System.Windows.Forms.MenuItem menuItemYesNoAlternation;
		private System.Windows.Forms.MenuItem menuItemNamedYesNoAlternation;
		private System.Windows.Forms.MenuItem menuItemInlineComment;
		private System.Windows.Forms.MenuItem menuItemXModeComment;
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.TextBox txtReplacementExpression;
		private System.Windows.Forms.Label lblReplacementExpression;
		private System.Windows.Forms.Label lblTestText;
		private System.Windows.Forms.TextBox txtTestText;
		private System.Windows.Forms.Label lblMatchReport;
		private System.Windows.Forms.Button btnCreateMatchReport;
		private System.Windows.Forms.TextBox txtMatchReport;
		private System.Windows.Forms.CheckedListBox cklRegExOptions;
		private System.Windows.Forms.Label lblRegExOptions;
		private System.Windows.Forms.MenuItem menuItemRegexHelp;
		private System.Windows.Forms.HelpProvider helpProviderRegexLanguage;
		private System.Windows.Forms.HelpProvider helpProviderRegexOptions;
		private System.Windows.Forms.ContextMenu contextMenuRegexOptions;
		private System.Windows.Forms.MenuItem menuItemRegexOptionsHelp;
		private System.Windows.Forms.Label lblIntro;
		private System.Windows.Forms.MenuItem menuItemRegexExamples;
		private System.Windows.Forms.MenuItem menuItemUSPhoneRegex;
		private System.Windows.Forms.MenuItem menuItemEmailRegex;
		private System.Windows.Forms.MenuItem menuItemUSZipRegex;
		private System.Windows.Forms.MenuItem menuItemRegexCut;
		private System.Windows.Forms.MenuItem menuItemRegexCopy;
		private System.Windows.Forms.MenuItem menuItemRegexPaste;
		private System.Windows.Forms.MenuItem menuItemRegexSelectAll;
		private System.Windows.Forms.ContextMenu contextMenuRegexReplacements;
		private System.Windows.Forms.MenuItem menuItemSubstitutions;
		private System.Windows.Forms.MenuItem menuItemRegexReplacementsHelp;
		private System.Windows.Forms.MenuItem menuItemRegexReplacementsCut;
		private System.Windows.Forms.MenuItem menuItemRegexReplacementsCopy;
		private System.Windows.Forms.MenuItem menuItemRegExReplacementsPaste;
		private System.Windows.Forms.MenuItem menuItemRegexReplacementsSelectAll;
		private System.Windows.Forms.MenuItem menuItemRegexSeperator1;
		private System.Windows.Forms.MenuItem menuItemRegexSeperator2;
		private System.Windows.Forms.MenuItem menuItemRegexReplacementsSeperator1;
		private System.Windows.Forms.MenuItem menuItemRegexReplacementsSeperator2;
		private System.Windows.Forms.MenuItem menuItemNumberedCapture;
		private System.Windows.Forms.MenuItem menuItemNamedCapture;
		private System.Windows.Forms.MenuItem menuItemLiteralDollarSubstitution;
		private System.Windows.Forms.MenuItem menuItemEntireMatch;
		private System.Windows.Forms.MenuItem menuItemBeforeMatch;
		private System.Windows.Forms.MenuItem menuItemAfterMatch;
		private System.Windows.Forms.MenuItem menuItemLastCapture;
		private System.Windows.Forms.MenuItem menuItemEntireInput;
		private System.Windows.Forms.MenuItem menuItemRegexUndo;
		private System.Windows.Forms.MenuItem menuItemRegexReplacementsUndo;
		private System.Windows.Forms.ErrorProvider errorProvider1;
		private System.Windows.Forms.MenuItem menuItemWebURLRegex;
		private System.Windows.Forms.MenuItem menuItemTrimWhitespace;
		private System.Windows.Forms.MenuItem menuItemCaptureCSVElements;
		private System.ComponentModel.IContainer components;

		public RegularExpressionTester()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// Create the checklist for Regular Expression Options from the RegexOptions enumeration.
			//
			foreach (string strName in System.Enum.GetNames(typeof(RegexOptions)))
			{
				int intItemIndex = this.cklRegExOptions.Items.Add(strName);

				if (strName == "None")
				{
					this.cklRegExOptions.SetItemChecked(intItemIndex, true);
				}
			}

			// Set appropriate column width from the longest known option text.
			Graphics g = this.cklRegExOptions.CreateGraphics();
			this.cklRegExOptions.ColumnWidth = g.MeasureString("IgnorePatternWhitespace", this.cklRegExOptions.Font).ToSize().Width + 25;
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.lblRegularExpression = new System.Windows.Forms.Label();
			this.txtRegularExpression = new System.Windows.Forms.TextBox();
			this.contextMenuRegularExpressions = new System.Windows.Forms.ContextMenu();
			this.menuItemRegexHelp = new System.Windows.Forms.MenuItem();
			this.menuItemRegexExamples = new System.Windows.Forms.MenuItem();
			this.menuItemUSPhoneRegex = new System.Windows.Forms.MenuItem();
			this.menuItemUSZipRegex = new System.Windows.Forms.MenuItem();
			this.menuItemEmailRegex = new System.Windows.Forms.MenuItem();
			this.menuItemWebURLRegex = new System.Windows.Forms.MenuItem();
			this.menuItemTrimWhitespace = new System.Windows.Forms.MenuItem();
			this.menuItemRegexSeperator1 = new System.Windows.Forms.MenuItem();
			this.menuItemCharacterEscapes = new System.Windows.Forms.MenuItem();
			this.menuItemBellCharacter = new System.Windows.Forms.MenuItem();
			this.menuItemWordBoundary = new System.Windows.Forms.MenuItem();
			this.menuItemTab = new System.Windows.Forms.MenuItem();
			this.menuItemCarriageReturn = new System.Windows.Forms.MenuItem();
			this.menuItemVerticalTab = new System.Windows.Forms.MenuItem();
			this.menuItemFormFeed = new System.Windows.Forms.MenuItem();
			this.menuItemNewLine = new System.Windows.Forms.MenuItem();
			this.menuItemEscapeCharacter = new System.Windows.Forms.MenuItem();
			this.menuItemOctalCharacter = new System.Windows.Forms.MenuItem();
			this.menuItemHexadecimalCharacter = new System.Windows.Forms.MenuItem();
			this.menuItemControlCharacter = new System.Windows.Forms.MenuItem();
			this.menuItemUnicodeCharacter = new System.Windows.Forms.MenuItem();
			this.menuItemCharacterEscape = new System.Windows.Forms.MenuItem();
			this.menuItemLiteralDot = new System.Windows.Forms.MenuItem();
			this.menuItemLiteralDollar = new System.Windows.Forms.MenuItem();
			this.menuItemLiteralCaret = new System.Windows.Forms.MenuItem();
			this.menuItemLiteralLeftBrace = new System.Windows.Forms.MenuItem();
			this.menuItemLiteralLeftBracket = new System.Windows.Forms.MenuItem();
			this.menuItemLiteralLeftParen = new System.Windows.Forms.MenuItem();
			this.menuItemLiteralVerticalBar = new System.Windows.Forms.MenuItem();
			this.menuItemLiteralRightParen = new System.Windows.Forms.MenuItem();
			this.menuItemLiteralAsterisk = new System.Windows.Forms.MenuItem();
			this.menuItemLiteralPlus = new System.Windows.Forms.MenuItem();
			this.menuItemLiteralQuestionMark = new System.Windows.Forms.MenuItem();
			this.menuItemLiteralDash = new System.Windows.Forms.MenuItem();
			this.menuItemLiteralNumberSign = new System.Windows.Forms.MenuItem();
			this.menuItemCharacterClasses = new System.Windows.Forms.MenuItem();
			this.menuItemAnyCharacter = new System.Windows.Forms.MenuItem();
			this.menuItemAnyCharacterInSet = new System.Windows.Forms.MenuItem();
			this.menuItemAnyCharacterNotInSet = new System.Windows.Forms.MenuItem();
			this.menuItemCharacterRange = new System.Windows.Forms.MenuItem();
			this.menuItemCharacterInNamedUnicodeBlock = new System.Windows.Forms.MenuItem();
			this.menuItemCharacterNotInNamedUnicodeBlock = new System.Windows.Forms.MenuItem();
			this.menuItemAnyWordCharacter = new System.Windows.Forms.MenuItem();
			this.menuItemAnyNonWordCharacter = new System.Windows.Forms.MenuItem();
			this.menuItemAnyWhitespaceCharacter = new System.Windows.Forms.MenuItem();
			this.menuItemAnyNonWhitespaceCharacter = new System.Windows.Forms.MenuItem();
			this.menuItemAnyDecimalDigit = new System.Windows.Forms.MenuItem();
			this.menuItemAnyNonDigit = new System.Windows.Forms.MenuItem();
			this.menuItemAtomicZeroWidthAssertions = new System.Windows.Forms.MenuItem();
			this.menuItemLineBegin = new System.Windows.Forms.MenuItem();
			this.menuItemLineEnd = new System.Windows.Forms.MenuItem();
			this.menuItemStringBegin = new System.Windows.Forms.MenuItem();
			this.menuItemStrinEndNonCR = new System.Windows.Forms.MenuItem();
			this.menuItemStringEnd = new System.Windows.Forms.MenuItem();
			this.menuItemPreviousMatchEnd = new System.Windows.Forms.MenuItem();
			this.menuItemWordBoundary2 = new System.Windows.Forms.MenuItem();
			this.menuItemNonWordBoundary = new System.Windows.Forms.MenuItem();
			this.menuItemQuantifiersStarQuantifier = new System.Windows.Forms.MenuItem();
			this.menuItemStarQuantifier = new System.Windows.Forms.MenuItem();
			this.menuItemPlusQuantifier = new System.Windows.Forms.MenuItem();
			this.menuItemQuestionMarkQuantifier = new System.Windows.Forms.MenuItem();
			this.menuItemExactQuantifier = new System.Windows.Forms.MenuItem();
			this.menuItemAtLeastQuantifier = new System.Windows.Forms.MenuItem();
			this.menuItemAtLeastButNotMoreQuantifier = new System.Windows.Forms.MenuItem();
			this.menuItemMatchFewestModifier = new System.Windows.Forms.MenuItem();
			this.menuItemGroupingConstructs = new System.Windows.Forms.MenuItem();
			this.menuItemAutoNumberedCaptureGroup = new System.Windows.Forms.MenuItem();
			this.menuItemNamedCaptureGroup = new System.Windows.Forms.MenuItem();
			this.menuItemBalancingCaptureGroup = new System.Windows.Forms.MenuItem();
			this.menuItemNonCapturingGroup = new System.Windows.Forms.MenuItem();
			this.menuItemOptionControlGroup = new System.Windows.Forms.MenuItem();
			this.menuItemZeroWidthPositiveLookahead = new System.Windows.Forms.MenuItem();
			this.menuItemZeroWidthNegativeLookahead = new System.Windows.Forms.MenuItem();
			this.menuItemZeroWidthPositiveLookbehind = new System.Windows.Forms.MenuItem();
			this.menuItemZeroWidthNegativeLookbehind = new System.Windows.Forms.MenuItem();
			this.menuItemNonBacktrackingSubexpression = new System.Windows.Forms.MenuItem();
			this.menuItemBackreferenceConstructs = new System.Windows.Forms.MenuItem();
			this.menuItemBackreference = new System.Windows.Forms.MenuItem();
			this.menuItemNamedBackreference = new System.Windows.Forms.MenuItem();
			this.menuItemAlternationConstructs = new System.Windows.Forms.MenuItem();
			this.menuItemOrAlternation = new System.Windows.Forms.MenuItem();
			this.menuItemYesNoAlternation = new System.Windows.Forms.MenuItem();
			this.menuItemNamedYesNoAlternation = new System.Windows.Forms.MenuItem();
			this.menuItemMiscellaneousConstructs = new System.Windows.Forms.MenuItem();
			this.menuItemInlineComment = new System.Windows.Forms.MenuItem();
			this.menuItemXModeComment = new System.Windows.Forms.MenuItem();
			this.menuItemRegexSeperator2 = new System.Windows.Forms.MenuItem();
			this.menuItemRegexUndo = new System.Windows.Forms.MenuItem();
			this.menuItemRegexCut = new System.Windows.Forms.MenuItem();
			this.menuItemRegexCopy = new System.Windows.Forms.MenuItem();
			this.menuItemRegexPaste = new System.Windows.Forms.MenuItem();
			this.menuItemRegexSelectAll = new System.Windows.Forms.MenuItem();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.txtReplacementExpression = new System.Windows.Forms.TextBox();
			this.contextMenuRegexReplacements = new System.Windows.Forms.ContextMenu();
			this.menuItemRegexReplacementsHelp = new System.Windows.Forms.MenuItem();
			this.menuItemRegexReplacementsSeperator1 = new System.Windows.Forms.MenuItem();
			this.menuItemSubstitutions = new System.Windows.Forms.MenuItem();
			this.menuItemNumberedCapture = new System.Windows.Forms.MenuItem();
			this.menuItemNamedCapture = new System.Windows.Forms.MenuItem();
			this.menuItemLiteralDollarSubstitution = new System.Windows.Forms.MenuItem();
			this.menuItemEntireMatch = new System.Windows.Forms.MenuItem();
			this.menuItemBeforeMatch = new System.Windows.Forms.MenuItem();
			this.menuItemAfterMatch = new System.Windows.Forms.MenuItem();
			this.menuItemLastCapture = new System.Windows.Forms.MenuItem();
			this.menuItemEntireInput = new System.Windows.Forms.MenuItem();
			this.menuItemRegexReplacementsSeperator2 = new System.Windows.Forms.MenuItem();
			this.menuItemRegexReplacementsUndo = new System.Windows.Forms.MenuItem();
			this.menuItemRegexReplacementsCut = new System.Windows.Forms.MenuItem();
			this.menuItemRegexReplacementsCopy = new System.Windows.Forms.MenuItem();
			this.menuItemRegExReplacementsPaste = new System.Windows.Forms.MenuItem();
			this.menuItemRegexReplacementsSelectAll = new System.Windows.Forms.MenuItem();
			this.txtTestText = new System.Windows.Forms.TextBox();
			this.btnCreateMatchReport = new System.Windows.Forms.Button();
			this.txtMatchReport = new System.Windows.Forms.TextBox();
			this.cklRegExOptions = new System.Windows.Forms.CheckedListBox();
			this.contextMenuRegexOptions = new System.Windows.Forms.ContextMenu();
			this.menuItemRegexOptionsHelp = new System.Windows.Forms.MenuItem();
			this.lblReplacementExpression = new System.Windows.Forms.Label();
			this.lblTestText = new System.Windows.Forms.Label();
			this.lblMatchReport = new System.Windows.Forms.Label();
			this.lblRegExOptions = new System.Windows.Forms.Label();
			this.helpProviderRegexLanguage = new System.Windows.Forms.HelpProvider();
			this.helpProviderRegexOptions = new System.Windows.Forms.HelpProvider();
			this.lblIntro = new System.Windows.Forms.Label();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider();
			this.menuItemCaptureCSVElements = new System.Windows.Forms.MenuItem();
			this.SuspendLayout();
			// 
			// lblRegularExpression
			// 
			this.lblRegularExpression.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lblRegularExpression.Location = new System.Drawing.Point(16, 80);
			this.lblRegularExpression.Name = "lblRegularExpression";
			this.lblRegularExpression.Size = new System.Drawing.Size(136, 20);
			this.lblRegularExpression.TabIndex = 99;
			this.lblRegularExpression.Text = "Regular Expression: ";
			this.lblRegularExpression.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtRegularExpression
			// 
			this.txtRegularExpression.AutoSize = false;
			this.txtRegularExpression.ContextMenu = this.contextMenuRegularExpressions;
			this.txtRegularExpression.Location = new System.Drawing.Point(184, 80);
			this.txtRegularExpression.Multiline = true;
			this.txtRegularExpression.Name = "txtRegularExpression";
			this.helpProviderRegexLanguage.SetShowHelp(this.txtRegularExpression, true);
			this.txtRegularExpression.Size = new System.Drawing.Size(512, 48);
			this.txtRegularExpression.TabIndex = 1;
			this.txtRegularExpression.Text = "";
			this.toolTip1.SetToolTip(this.txtRegularExpression, "The regular expression string to use for matching.");
			// 
			// contextMenuRegularExpressions
			// 
			this.contextMenuRegularExpressions.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																										  this.menuItemRegexHelp,
																										  this.menuItemRegexExamples,
																										  this.menuItemRegexSeperator1,
																										  this.menuItemCharacterEscapes,
																										  this.menuItemCharacterClasses,
																										  this.menuItemAtomicZeroWidthAssertions,
																										  this.menuItemQuantifiersStarQuantifier,
																										  this.menuItemGroupingConstructs,
																										  this.menuItemBackreferenceConstructs,
																										  this.menuItemAlternationConstructs,
																										  this.menuItemMiscellaneousConstructs,
																										  this.menuItemRegexSeperator2,
																										  this.menuItemRegexUndo,
																										  this.menuItemRegexCut,
																										  this.menuItemRegexCopy,
																										  this.menuItemRegexPaste,
																										  this.menuItemRegexSelectAll});
			// 
			// menuItemRegexHelp
			// 
			this.menuItemRegexHelp.Index = 0;
			this.menuItemRegexHelp.Text = "Help with Regular Expressions";
			this.menuItemRegexHelp.Click += new System.EventHandler(this.menuItemRegexHelp_Click);
			// 
			// menuItemRegexExamples
			// 
			this.menuItemRegexExamples.Index = 1;
			this.menuItemRegexExamples.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																								  this.menuItemUSPhoneRegex,
																								  this.menuItemUSZipRegex,
																								  this.menuItemEmailRegex,
																								  this.menuItemWebURLRegex,
																								  this.menuItemTrimWhitespace,
																								  this.menuItemCaptureCSVElements});
			this.menuItemRegexExamples.Text = "Example Regular Expressions";
			// 
			// menuItemUSPhoneRegex
			// 
			this.menuItemUSPhoneRegex.Index = 0;
			this.menuItemUSPhoneRegex.Text = "US Phone Number Validation";
			this.menuItemUSPhoneRegex.Click += new System.EventHandler(this.menuItemUSPhoneRegex_Click);
			// 
			// menuItemUSZipRegex
			// 
			this.menuItemUSZipRegex.Index = 1;
			this.menuItemUSZipRegex.Text = "US Zip Code Validation";
			this.menuItemUSZipRegex.Click += new System.EventHandler(this.menuItemUSZipRegex_Click);
			// 
			// menuItemEmailRegex
			// 
			this.menuItemEmailRegex.Index = 2;
			this.menuItemEmailRegex.Text = "Email Address Validation";
			this.menuItemEmailRegex.Click += new System.EventHandler(this.menuItemEmailRegex_Click);
			// 
			// menuItemWebURLRegex
			// 
			this.menuItemWebURLRegex.Index = 3;
			this.menuItemWebURLRegex.Text = "Web URL Validation";
			this.menuItemWebURLRegex.Click += new System.EventHandler(this.menuItemWebURLRegex_Click);
			// 
			// menuItemTrimWhitespace
			// 
			this.menuItemTrimWhitespace.Index = 4;
			this.menuItemTrimWhitespace.Text = "Trim Whitespace";
			this.menuItemTrimWhitespace.Click += new System.EventHandler(this.menuItemTrimWhitespace_Click);
			// 
			// menuItemRegexSeperator1
			// 
			this.menuItemRegexSeperator1.Index = 2;
			this.menuItemRegexSeperator1.Text = "-";
			// 
			// menuItemCharacterEscapes
			// 
			this.menuItemCharacterEscapes.Index = 3;
			this.menuItemCharacterEscapes.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																									 this.menuItemBellCharacter,
																									 this.menuItemWordBoundary,
																									 this.menuItemTab,
																									 this.menuItemCarriageReturn,
																									 this.menuItemVerticalTab,
																									 this.menuItemFormFeed,
																									 this.menuItemNewLine,
																									 this.menuItemEscapeCharacter,
																									 this.menuItemOctalCharacter,
																									 this.menuItemHexadecimalCharacter,
																									 this.menuItemControlCharacter,
																									 this.menuItemUnicodeCharacter,
																									 this.menuItemCharacterEscape});
			this.menuItemCharacterEscapes.Text = "Character Escapes";
			// 
			// menuItemBellCharacter
			// 
			this.menuItemBellCharacter.Index = 0;
			this.menuItemBellCharacter.Text = "\\a (Bell character)";
			this.menuItemBellCharacter.Click += new System.EventHandler(this.menuItemBellCharacter_Click);
			// 
			// menuItemWordBoundary
			// 
			this.menuItemWordBoundary.Index = 1;
			this.menuItemWordBoundary.Text = "\\b (Word boundary; Backspace inside [] and replacements)";
			this.menuItemWordBoundary.Click += new System.EventHandler(this.menuItemWordBoundary_Click);
			// 
			// menuItemTab
			// 
			this.menuItemTab.Index = 2;
			this.menuItemTab.Text = "\\t (Tab)";
			this.menuItemTab.Click += new System.EventHandler(this.menuItemTab_Click);
			// 
			// menuItemCarriageReturn
			// 
			this.menuItemCarriageReturn.Index = 3;
			this.menuItemCarriageReturn.Text = "\\r (Carriage return)";
			this.menuItemCarriageReturn.Click += new System.EventHandler(this.menuItemCarriageReturn_Click);
			// 
			// menuItemVerticalTab
			// 
			this.menuItemVerticalTab.Index = 4;
			this.menuItemVerticalTab.Text = "\\v (Vertical tab)";
			this.menuItemVerticalTab.Click += new System.EventHandler(this.menuItemVerticalTab_Click);
			// 
			// menuItemFormFeed
			// 
			this.menuItemFormFeed.Index = 5;
			this.menuItemFormFeed.Text = "\\f (Form feed)";
			this.menuItemFormFeed.Click += new System.EventHandler(this.menuItemFormFeed_Click);
			// 
			// menuItemNewLine
			// 
			this.menuItemNewLine.Index = 6;
			this.menuItemNewLine.Text = "\\n (New line)";
			this.menuItemNewLine.Click += new System.EventHandler(this.menuItemNewLine_Click);
			// 
			// menuItemEscapeCharacter
			// 
			this.menuItemEscapeCharacter.Index = 7;
			this.menuItemEscapeCharacter.Text = "\\e (Escape)";
			this.menuItemEscapeCharacter.Click += new System.EventHandler(this.menuItemEscapeCharacter_Click);
			// 
			// menuItemOctalCharacter
			// 
			this.menuItemOctalCharacter.Index = 8;
			this.menuItemOctalCharacter.Text = "\\O (Octal character representation)";
			this.menuItemOctalCharacter.Click += new System.EventHandler(this.menuItemOctalCharacter_Click);
			// 
			// menuItemHexadecimalCharacter
			// 
			this.menuItemHexadecimalCharacter.Index = 9;
			this.menuItemHexadecimalCharacter.Text = "\\x (Hexadecimal character representation)";
			this.menuItemHexadecimalCharacter.Click += new System.EventHandler(this.menuItemHexadecimalCharacter_Click);
			// 
			// menuItemControlCharacter
			// 
			this.menuItemControlCharacter.Index = 10;
			this.menuItemControlCharacter.Text = "\\c (Control character representation)";
			this.menuItemControlCharacter.Click += new System.EventHandler(this.menuItemControlCharacter_Click);
			// 
			// menuItemUnicodeCharacter
			// 
			this.menuItemUnicodeCharacter.Index = 11;
			this.menuItemUnicodeCharacter.Text = "\\u (Unicode character representation)";
			this.menuItemUnicodeCharacter.Click += new System.EventHandler(this.menuItemUnicodeCharacter_Click);
			// 
			// menuItemCharacterEscape
			// 
			this.menuItemCharacterEscape.Index = 12;
			this.menuItemCharacterEscape.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																									this.menuItemLiteralDot,
																									this.menuItemLiteralDollar,
																									this.menuItemLiteralCaret,
																									this.menuItemLiteralLeftBrace,
																									this.menuItemLiteralLeftBracket,
																									this.menuItemLiteralLeftParen,
																									this.menuItemLiteralVerticalBar,
																									this.menuItemLiteralRightParen,
																									this.menuItemLiteralAsterisk,
																									this.menuItemLiteralPlus,
																									this.menuItemLiteralQuestionMark,
																									this.menuItemLiteralDash,
																									this.menuItemLiteralNumberSign});
			this.menuItemCharacterEscape.Text = "\\ (Escape sequence for the special characters .$^{[(|)*+?\\#)";
			// 
			// menuItemLiteralDot
			// 
			this.menuItemLiteralDot.Index = 0;
			this.menuItemLiteralDot.Text = "\\. (literal .)";
			this.menuItemLiteralDot.Click += new System.EventHandler(this.menuItemLiteralDot_Click);
			// 
			// menuItemLiteralDollar
			// 
			this.menuItemLiteralDollar.Index = 1;
			this.menuItemLiteralDollar.Text = "\\$ (literal $)";
			this.menuItemLiteralDollar.Click += new System.EventHandler(this.menuItemLiteralDollar_Click);
			// 
			// menuItemLiteralCaret
			// 
			this.menuItemLiteralCaret.Index = 2;
			this.menuItemLiteralCaret.Text = "\\^ (literal ^)";
			this.menuItemLiteralCaret.Click += new System.EventHandler(this.menuItemLiteralCaret_Click);
			// 
			// menuItemLiteralLeftBrace
			// 
			this.menuItemLiteralLeftBrace.Index = 3;
			this.menuItemLiteralLeftBrace.Text = "\\{ (literal {)";
			this.menuItemLiteralLeftBrace.Click += new System.EventHandler(this.menuItemLiteralLeftBrace_Click);
			// 
			// menuItemLiteralLeftBracket
			// 
			this.menuItemLiteralLeftBracket.Index = 4;
			this.menuItemLiteralLeftBracket.Text = "\\[ (literal [)";
			this.menuItemLiteralLeftBracket.Click += new System.EventHandler(this.menuItemLiteralLeftBracket_Click);
			// 
			// menuItemLiteralLeftParen
			// 
			this.menuItemLiteralLeftParen.Index = 5;
			this.menuItemLiteralLeftParen.Text = "\\( (literal ()";
			this.menuItemLiteralLeftParen.Click += new System.EventHandler(this.menuItemLiteralLeftParen_Click);
			// 
			// menuItemLiteralVerticalBar
			// 
			this.menuItemLiteralVerticalBar.Index = 6;
			this.menuItemLiteralVerticalBar.Text = "\\| (literal |)";
			this.menuItemLiteralVerticalBar.Click += new System.EventHandler(this.menuItemLiteralVerticalBar_Click);
			// 
			// menuItemLiteralRightParen
			// 
			this.menuItemLiteralRightParen.Index = 7;
			this.menuItemLiteralRightParen.Text = "\\) (literal ))";
			this.menuItemLiteralRightParen.Click += new System.EventHandler(this.menuItemLiteralRightParen_Click);
			// 
			// menuItemLiteralAsterisk
			// 
			this.menuItemLiteralAsterisk.Index = 8;
			this.menuItemLiteralAsterisk.Text = "\\* (literal *)";
			this.menuItemLiteralAsterisk.Click += new System.EventHandler(this.menuItemLiteralAsterisk_Click);
			// 
			// menuItemLiteralPlus
			// 
			this.menuItemLiteralPlus.Index = 9;
			this.menuItemLiteralPlus.Text = "\\+ (literal +)";
			this.menuItemLiteralPlus.Click += new System.EventHandler(this.menuItemLiteralPlus_Click);
			// 
			// menuItemLiteralQuestionMark
			// 
			this.menuItemLiteralQuestionMark.Index = 10;
			this.menuItemLiteralQuestionMark.Text = "\\? (literal ?)";
			this.menuItemLiteralQuestionMark.Click += new System.EventHandler(this.menuItemLiteralQuestionMark_Click);
			// 
			// menuItemLiteralDash
			// 
			this.menuItemLiteralDash.Index = 11;
			this.menuItemLiteralDash.Text = "\\- (literal - for inside [])";
			this.menuItemLiteralDash.Click += new System.EventHandler(this.menuItemLiteralDash_Click);
			// 
			// menuItemLiteralNumberSign
			// 
			this.menuItemLiteralNumberSign.Index = 12;
			this.menuItemLiteralNumberSign.Text = "\\# (literal #)";
			this.menuItemLiteralNumberSign.Click += new System.EventHandler(this.menuItemLiteralNumberSign_Click);
			// 
			// menuItemCharacterClasses
			// 
			this.menuItemCharacterClasses.Index = 4;
			this.menuItemCharacterClasses.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																									 this.menuItemAnyCharacter,
																									 this.menuItemAnyCharacterInSet,
																									 this.menuItemAnyCharacterNotInSet,
																									 this.menuItemCharacterRange,
																									 this.menuItemCharacterInNamedUnicodeBlock,
																									 this.menuItemCharacterNotInNamedUnicodeBlock,
																									 this.menuItemAnyWordCharacter,
																									 this.menuItemAnyNonWordCharacter,
																									 this.menuItemAnyWhitespaceCharacter,
																									 this.menuItemAnyNonWhitespaceCharacter,
																									 this.menuItemAnyDecimalDigit,
																									 this.menuItemAnyNonDigit});
			this.menuItemCharacterClasses.Text = "Character Classes";
			// 
			// menuItemAnyCharacter
			// 
			this.menuItemAnyCharacter.Index = 0;
			this.menuItemAnyCharacter.Text = ". (Matches any character except \\n)";
			this.menuItemAnyCharacter.Click += new System.EventHandler(this.menuItemAnyCharacter_Click);
			// 
			// menuItemAnyCharacterInSet
			// 
			this.menuItemAnyCharacterInSet.Index = 1;
			this.menuItemAnyCharacterInSet.Text = "[aeiou] (Matches any single character included in the specified set)";
			this.menuItemAnyCharacterInSet.Click += new System.EventHandler(this.menuItemAnyCharacterInSet_Click);
			// 
			// menuItemAnyCharacterNotInSet
			// 
			this.menuItemAnyCharacterNotInSet.Index = 2;
			this.menuItemAnyCharacterNotInSet.Text = "[^aeiou] (Matches any single character included not in the specified set)";
			this.menuItemAnyCharacterNotInSet.Click += new System.EventHandler(this.menuItemAnyCharacterNotInSet_Click);
			// 
			// menuItemCharacterRange
			// 
			this.menuItemCharacterRange.Index = 3;
			this.menuItemCharacterRange.Text = "- (Used to specify a range of caharacters inside of a set [0-9A-Z])";
			this.menuItemCharacterRange.Click += new System.EventHandler(this.menuItemCharacterRange_Click);
			// 
			// menuItemCharacterInNamedUnicodeBlock
			// 
			this.menuItemCharacterInNamedUnicodeBlock.Index = 4;
			this.menuItemCharacterInNamedUnicodeBlock.Text = "\\p{name} (Matches any character in a named Unicode group or block)";
			this.menuItemCharacterInNamedUnicodeBlock.Click += new System.EventHandler(this.menuItemCharacterInNamedUnicodeBlock_Click);
			// 
			// menuItemCharacterNotInNamedUnicodeBlock
			// 
			this.menuItemCharacterNotInNamedUnicodeBlock.Index = 5;
			this.menuItemCharacterNotInNamedUnicodeBlock.Text = "\\P{name} (Matches any character not in a named Unicode group or block)";
			this.menuItemCharacterNotInNamedUnicodeBlock.Click += new System.EventHandler(this.menuItemCharacterNotInNamedUnicodeBlock_Click);
			// 
			// menuItemAnyWordCharacter
			// 
			this.menuItemAnyWordCharacter.Index = 6;
			this.menuItemAnyWordCharacter.Text = "\\w (Matches any word character)";
			this.menuItemAnyWordCharacter.Click += new System.EventHandler(this.menuItemAnyWordCharacter_Click);
			// 
			// menuItemAnyNonWordCharacter
			// 
			this.menuItemAnyNonWordCharacter.Index = 7;
			this.menuItemAnyNonWordCharacter.Text = "\\W (Matches any non-word character)";
			this.menuItemAnyNonWordCharacter.Click += new System.EventHandler(this.menuItemAnyNonWordCharacter_Click);
			// 
			// menuItemAnyWhitespaceCharacter
			// 
			this.menuItemAnyWhitespaceCharacter.Index = 8;
			this.menuItemAnyWhitespaceCharacter.Text = "\\s (Matches any white-space character)";
			this.menuItemAnyWhitespaceCharacter.Click += new System.EventHandler(this.menuItemAnyWhitespaceCharacter_Click);
			// 
			// menuItemAnyNonWhitespaceCharacter
			// 
			this.menuItemAnyNonWhitespaceCharacter.Index = 9;
			this.menuItemAnyNonWhitespaceCharacter.Text = "\\S (Matches any non-white-space character)";
			this.menuItemAnyNonWhitespaceCharacter.Click += new System.EventHandler(this.menuItemAnyNonWhitespaceCharacter_Click);
			// 
			// menuItemAnyDecimalDigit
			// 
			this.menuItemAnyDecimalDigit.Index = 10;
			this.menuItemAnyDecimalDigit.Text = "\\d (Matches any decimal digit)";
			this.menuItemAnyDecimalDigit.Click += new System.EventHandler(this.menuItemAnyDecimalDigit_Click);
			// 
			// menuItemAnyNonDigit
			// 
			this.menuItemAnyNonDigit.Index = 11;
			this.menuItemAnyNonDigit.Text = "\\D (Matches any nondigit)";
			this.menuItemAnyNonDigit.Click += new System.EventHandler(this.menuItemAnyNonDigit_Click);
			// 
			// menuItemAtomicZeroWidthAssertions
			// 
			this.menuItemAtomicZeroWidthAssertions.Index = 5;
			this.menuItemAtomicZeroWidthAssertions.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																											  this.menuItemLineBegin,
																											  this.menuItemLineEnd,
																											  this.menuItemStringBegin,
																											  this.menuItemStrinEndNonCR,
																											  this.menuItemStringEnd,
																											  this.menuItemPreviousMatchEnd,
																											  this.menuItemWordBoundary2,
																											  this.menuItemNonWordBoundary});
			this.menuItemAtomicZeroWidthAssertions.Text = "Atomic Zero-Width Assertions";
			// 
			// menuItemLineBegin
			// 
			this.menuItemLineBegin.Index = 0;
			this.menuItemLineBegin.Text = "^ (Beginning of line or string)";
			this.menuItemLineBegin.Click += new System.EventHandler(this.menuItemLineBegin_Click);
			// 
			// menuItemLineEnd
			// 
			this.menuItemLineEnd.Index = 1;
			this.menuItemLineEnd.Text = "$ (End of line or string)";
			this.menuItemLineEnd.Click += new System.EventHandler(this.menuItemLineEnd_Click);
			// 
			// menuItemStringBegin
			// 
			this.menuItemStringBegin.Index = 2;
			this.menuItemStringBegin.Text = "\\A (Beginning of string)";
			this.menuItemStringBegin.Click += new System.EventHandler(this.menuItemStringBegin_Click);
			// 
			// menuItemStrinEndNonCR
			// 
			this.menuItemStrinEndNonCR.Index = 3;
			this.menuItemStrinEndNonCR.Text = "\\Z (End of string or before \\n at the end of string )";
			this.menuItemStrinEndNonCR.Click += new System.EventHandler(this.menuItemStrinEndNonCR_Click);
			// 
			// menuItemStringEnd
			// 
			this.menuItemStringEnd.Index = 4;
			this.menuItemStringEnd.Text = "\\z (End of string)";
			this.menuItemStringEnd.Click += new System.EventHandler(this.menuItemStringEnd_Click);
			// 
			// menuItemPreviousMatchEnd
			// 
			this.menuItemPreviousMatchEnd.Index = 5;
			this.menuItemPreviousMatchEnd.Text = "\\G (Match must occur where previous match ended)";
			this.menuItemPreviousMatchEnd.Click += new System.EventHandler(this.menuItemPreviousMatchEnd_Click);
			// 
			// menuItemWordBoundary2
			// 
			this.menuItemWordBoundary2.Index = 6;
			this.menuItemWordBoundary2.Text = "\\b (Match must occur on a word boundary)";
			this.menuItemWordBoundary2.Click += new System.EventHandler(this.menuItemWordBoundary2_Click);
			// 
			// menuItemNonWordBoundary
			// 
			this.menuItemNonWordBoundary.Index = 7;
			this.menuItemNonWordBoundary.Text = "\\B (Match must not occur on a word boundary)";
			this.menuItemNonWordBoundary.Click += new System.EventHandler(this.menuItemNonWordBoundary_Click);
			// 
			// menuItemQuantifiersStarQuantifier
			// 
			this.menuItemQuantifiersStarQuantifier.Index = 6;
			this.menuItemQuantifiersStarQuantifier.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																											  this.menuItemStarQuantifier,
																											  this.menuItemPlusQuantifier,
																											  this.menuItemQuestionMarkQuantifier,
																											  this.menuItemExactQuantifier,
																											  this.menuItemAtLeastQuantifier,
																											  this.menuItemAtLeastButNotMoreQuantifier,
																											  this.menuItemMatchFewestModifier});
			this.menuItemQuantifiersStarQuantifier.Text = "Quantifiers";
			// 
			// menuItemStarQuantifier
			// 
			this.menuItemStarQuantifier.Index = 0;
			this.menuItemStarQuantifier.Text = "* (0 or more matches)";
			this.menuItemStarQuantifier.Click += new System.EventHandler(this.menuItemStarQuantifier_Click);
			// 
			// menuItemPlusQuantifier
			// 
			this.menuItemPlusQuantifier.Index = 1;
			this.menuItemPlusQuantifier.Text = "+ (1 or more matches)";
			this.menuItemPlusQuantifier.Click += new System.EventHandler(this.menuItemPlusQuantifier_Click);
			// 
			// menuItemQuestionMarkQuantifier
			// 
			this.menuItemQuestionMarkQuantifier.Index = 2;
			this.menuItemQuestionMarkQuantifier.Text = "? (0 or 1 matches)";
			this.menuItemQuestionMarkQuantifier.Click += new System.EventHandler(this.menuItemQuestionMarkQuantifier_Click);
			// 
			// menuItemExactQuantifier
			// 
			this.menuItemExactQuantifier.Index = 3;
			this.menuItemExactQuantifier.Text = "{n} (exactly n matches)";
			this.menuItemExactQuantifier.Click += new System.EventHandler(this.menuItemExactQuantifier_Click);
			// 
			// menuItemAtLeastQuantifier
			// 
			this.menuItemAtLeastQuantifier.Index = 4;
			this.menuItemAtLeastQuantifier.Text = "{n,} (at least n matches)";
			this.menuItemAtLeastQuantifier.Click += new System.EventHandler(this.menuItemAtLeastQuantifier_Click);
			// 
			// menuItemAtLeastButNotMoreQuantifier
			// 
			this.menuItemAtLeastButNotMoreQuantifier.Index = 5;
			this.menuItemAtLeastButNotMoreQuantifier.Text = "{n,m} (at least n matches, but no more than m matches)";
			this.menuItemAtLeastButNotMoreQuantifier.Click += new System.EventHandler(this.menuItemAtLeastButNotMoreQuantifier_Click);
			// 
			// menuItemMatchFewestModifier
			// 
			this.menuItemMatchFewestModifier.Index = 6;
			this.menuItemMatchFewestModifier.Text = "? after a quantifier (match the fewest possible characters)";
			this.menuItemMatchFewestModifier.Click += new System.EventHandler(this.menuItemMatchFewestModifier_Click);
			// 
			// menuItemGroupingConstructs
			// 
			this.menuItemGroupingConstructs.Index = 7;
			this.menuItemGroupingConstructs.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																									   this.menuItemAutoNumberedCaptureGroup,
																									   this.menuItemNamedCaptureGroup,
																									   this.menuItemBalancingCaptureGroup,
																									   this.menuItemNonCapturingGroup,
																									   this.menuItemOptionControlGroup,
																									   this.menuItemZeroWidthPositiveLookahead,
																									   this.menuItemZeroWidthNegativeLookahead,
																									   this.menuItemZeroWidthPositiveLookbehind,
																									   this.menuItemZeroWidthNegativeLookbehind,
																									   this.menuItemNonBacktrackingSubexpression});
			this.menuItemGroupingConstructs.Text = "Grouping Constructs";
			// 
			// menuItemAutoNumberedCaptureGroup
			// 
			this.menuItemAutoNumberedCaptureGroup.Index = 0;
			this.menuItemAutoNumberedCaptureGroup.Text = "() (an automatically numbered, starting with 1, capture group)";
			this.menuItemAutoNumberedCaptureGroup.Click += new System.EventHandler(this.menuItemAutoNumberedCaptureGroup_Click);
			// 
			// menuItemNamedCaptureGroup
			// 
			this.menuItemNamedCaptureGroup.Index = 1;
			this.menuItemNamedCaptureGroup.Text = "(?<name>expression) (a capture group named name)";
			this.menuItemNamedCaptureGroup.Click += new System.EventHandler(this.menuItemNamedCaptureGroup_Click);
			// 
			// menuItemBalancingCaptureGroup
			// 
			this.menuItemBalancingCaptureGroup.Index = 2;
			this.menuItemBalancingCaptureGroup.Text = "(?<name1-name2> ) (a balancing capture group)";
			this.menuItemBalancingCaptureGroup.Click += new System.EventHandler(this.menuItemBalancingCaptureGroup_Click);
			// 
			// menuItemNonCapturingGroup
			// 
			this.menuItemNonCapturingGroup.Index = 3;
			this.menuItemNonCapturingGroup.Text = "(?: ) (a non-capturing group)";
			this.menuItemNonCapturingGroup.Click += new System.EventHandler(this.menuItemNonCapturingGroup_Click);
			// 
			// menuItemOptionControlGroup
			// 
			this.menuItemOptionControlGroup.Index = 4;
			this.menuItemOptionControlGroup.Text = "(?imnsx-imnsx:   ) (Applies or disables the specified options within the subexpre" +
				"ssion (?i-s: ))";
			this.menuItemOptionControlGroup.Click += new System.EventHandler(this.menuItemOptionControlGroup_Click);
			// 
			// menuItemZeroWidthPositiveLookahead
			// 
			this.menuItemZeroWidthPositiveLookahead.Index = 5;
			this.menuItemZeroWidthPositiveLookahead.Text = "(?=   ) (Zero-width positive lookahead assertion)";
			this.menuItemZeroWidthPositiveLookahead.Click += new System.EventHandler(this.menuItemZeroWidthPositiveLookahead_Click);
			// 
			// menuItemZeroWidthNegativeLookahead
			// 
			this.menuItemZeroWidthNegativeLookahead.Index = 6;
			this.menuItemZeroWidthNegativeLookahead.Text = "(?!   ) (Zero-width negative lookahead assertion)";
			this.menuItemZeroWidthNegativeLookahead.Click += new System.EventHandler(this.menuItemZeroWidthNegativeLookahead_Click);
			// 
			// menuItemZeroWidthPositiveLookbehind
			// 
			this.menuItemZeroWidthPositiveLookbehind.Index = 7;
			this.menuItemZeroWidthPositiveLookbehind.Text = "(?<=   ) (Zero-width positive lookbehind assertion)";
			this.menuItemZeroWidthPositiveLookbehind.Click += new System.EventHandler(this.menuItemZeroWidthPositiveLookbehind_Click);
			// 
			// menuItemZeroWidthNegativeLookbehind
			// 
			this.menuItemZeroWidthNegativeLookbehind.Index = 8;
			this.menuItemZeroWidthNegativeLookbehind.Text = "(?<!   ) (Zero-width negative lookbehind assertion)";
			this.menuItemZeroWidthNegativeLookbehind.Click += new System.EventHandler(this.menuItemZeroWidthNegativeLookbehind_Click);
			// 
			// menuItemNonBacktrackingSubexpression
			// 
			this.menuItemNonBacktrackingSubexpression.Index = 9;
			this.menuItemNonBacktrackingSubexpression.Text = "(?>   ) (Nonbacktracking subexpression)";
			this.menuItemNonBacktrackingSubexpression.Click += new System.EventHandler(this.menuItemNonBacktrackingSubexpression_Click);
			// 
			// menuItemBackreferenceConstructs
			// 
			this.menuItemBackreferenceConstructs.Index = 8;
			this.menuItemBackreferenceConstructs.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																											this.menuItemBackreference,
																											this.menuItemNamedBackreference});
			this.menuItemBackreferenceConstructs.Text = "Backreference Constructs";
			// 
			// menuItemBackreference
			// 
			this.menuItemBackreference.Index = 0;
			this.menuItemBackreference.Text = "\\number (Backreference)";
			this.menuItemBackreference.Click += new System.EventHandler(this.menuItemBackreference_Click);
			// 
			// menuItemNamedBackreference
			// 
			this.menuItemNamedBackreference.Index = 1;
			this.menuItemNamedBackreference.Text = "\\k<name> (Named backreference)";
			this.menuItemNamedBackreference.Click += new System.EventHandler(this.menuItemNamedBackreference_Click);
			// 
			// menuItemAlternationConstructs
			// 
			this.menuItemAlternationConstructs.Index = 9;
			this.menuItemAlternationConstructs.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																										  this.menuItemOrAlternation,
																										  this.menuItemYesNoAlternation,
																										  this.menuItemNamedYesNoAlternation});
			this.menuItemAlternationConstructs.Text = "Alternation Constructs";
			// 
			// menuItemOrAlternation
			// 
			this.menuItemOrAlternation.Index = 0;
			this.menuItemOrAlternation.Text = "| (Matches any one of the terms separated by the vertical bar)";
			this.menuItemOrAlternation.Click += new System.EventHandler(this.menuItemOrAlternation_Click);
			// 
			// menuItemYesNoAlternation
			// 
			this.menuItemYesNoAlternation.Index = 1;
			this.menuItemYesNoAlternation.Text = "(?(?=expression)yes|no) (Matches the \"yes\" part if the expression matches at this" +
				" point; otherwise, matches the \"no\" part)";
			this.menuItemYesNoAlternation.Click += new System.EventHandler(this.menuItemYesNoAlternation_Click);
			// 
			// menuItemNamedYesNoAlternation
			// 
			this.menuItemNamedYesNoAlternation.Index = 2;
			this.menuItemNamedYesNoAlternation.Text = "(?(name)yes|no) (Matches the \"yes\" part if the named capture string has a match; " +
				"otherwise, matches the \"no\" part)";
			this.menuItemNamedYesNoAlternation.Click += new System.EventHandler(this.menuItemNamedYesNoAlternation_Click);
			// 
			// menuItemMiscellaneousConstructs
			// 
			this.menuItemMiscellaneousConstructs.Index = 10;
			this.menuItemMiscellaneousConstructs.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																											this.menuItemInlineComment,
																											this.menuItemXModeComment});
			this.menuItemMiscellaneousConstructs.Text = "Miscellaneous Constructs";
			// 
			// menuItemInlineComment
			// 
			this.menuItemInlineComment.Index = 0;
			this.menuItemInlineComment.Text = "(?#   ) (inline comment)";
			this.menuItemInlineComment.Click += new System.EventHandler(this.menuItemInlineComment_Click);
			// 
			// menuItemXModeComment
			// 
			this.menuItemXModeComment.Index = 1;
			this.menuItemXModeComment.Text = "# (X-mode comment)";
			this.menuItemXModeComment.Click += new System.EventHandler(this.menuItemXModeComment_Click);
			// 
			// menuItemRegexSeperator2
			// 
			this.menuItemRegexSeperator2.Index = 11;
			this.menuItemRegexSeperator2.Text = "-";
			// 
			// menuItemRegexUndo
			// 
			this.menuItemRegexUndo.Index = 12;
			this.menuItemRegexUndo.Text = "Undo";
			this.menuItemRegexUndo.Click += new System.EventHandler(this.menuItemRegexUndo_Click);
			// 
			// menuItemRegexCut
			// 
			this.menuItemRegexCut.Index = 13;
			this.menuItemRegexCut.Text = "Cut";
			this.menuItemRegexCut.Click += new System.EventHandler(this.menuItemRegexCut_Click);
			// 
			// menuItemRegexCopy
			// 
			this.menuItemRegexCopy.Index = 14;
			this.menuItemRegexCopy.Text = "Copy";
			this.menuItemRegexCopy.Click += new System.EventHandler(this.menuItemRegexCopy_Click);
			// 
			// menuItemRegexPaste
			// 
			this.menuItemRegexPaste.Index = 15;
			this.menuItemRegexPaste.Text = "Paste";
			this.menuItemRegexPaste.Click += new System.EventHandler(this.menuItemRegexPaste_Click);
			// 
			// menuItemRegexSelectAll
			// 
			this.menuItemRegexSelectAll.Index = 16;
			this.menuItemRegexSelectAll.Text = "Select All";
			this.menuItemRegexSelectAll.Click += new System.EventHandler(this.menuItemRegexSelectAll_Click);
			// 
			// txtReplacementExpression
			// 
			this.txtReplacementExpression.ContextMenu = this.contextMenuRegexReplacements;
			this.txtReplacementExpression.Location = new System.Drawing.Point(184, 240);
			this.txtReplacementExpression.Multiline = true;
			this.txtReplacementExpression.Name = "txtReplacementExpression";
			this.helpProviderRegexLanguage.SetShowHelp(this.txtReplacementExpression, true);
			this.txtReplacementExpression.Size = new System.Drawing.Size(512, 48);
			this.txtReplacementExpression.TabIndex = 3;
			this.txtReplacementExpression.Text = "";
			this.toolTip1.SetToolTip(this.txtReplacementExpression, "The text or expression to use when performing replacements on matches.");
			// 
			// contextMenuRegexReplacements
			// 
			this.contextMenuRegexReplacements.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																										 this.menuItemRegexReplacementsHelp,
																										 this.menuItemRegexReplacementsSeperator1,
																										 this.menuItemSubstitutions,
																										 this.menuItemRegexReplacementsSeperator2,
																										 this.menuItemRegexReplacementsUndo,
																										 this.menuItemRegexReplacementsCut,
																										 this.menuItemRegexReplacementsCopy,
																										 this.menuItemRegExReplacementsPaste,
																										 this.menuItemRegexReplacementsSelectAll});
			// 
			// menuItemRegexReplacementsHelp
			// 
			this.menuItemRegexReplacementsHelp.Index = 0;
			this.menuItemRegexReplacementsHelp.Text = "Help with Regular Expressions";
			this.menuItemRegexReplacementsHelp.Click += new System.EventHandler(this.menuItemRegexReplacementsHelp_Click);
			// 
			// menuItemRegexReplacementsSeperator1
			// 
			this.menuItemRegexReplacementsSeperator1.Index = 1;
			this.menuItemRegexReplacementsSeperator1.Text = "-";
			// 
			// menuItemSubstitutions
			// 
			this.menuItemSubstitutions.Index = 2;
			this.menuItemSubstitutions.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																								  this.menuItemNumberedCapture,
																								  this.menuItemNamedCapture,
																								  this.menuItemLiteralDollarSubstitution,
																								  this.menuItemEntireMatch,
																								  this.menuItemBeforeMatch,
																								  this.menuItemAfterMatch,
																								  this.menuItemLastCapture,
																								  this.menuItemEntireInput});
			this.menuItemSubstitutions.Text = "Substitutions";
			// 
			// menuItemNumberedCapture
			// 
			this.menuItemNumberedCapture.Index = 0;
			this.menuItemNumberedCapture.Text = "$number (Last substring matched by group number)";
			this.menuItemNumberedCapture.Click += new System.EventHandler(this.menuItemNumberedCapture_Click);
			// 
			// menuItemNamedCapture
			// 
			this.menuItemNamedCapture.Index = 1;
			this.menuItemNamedCapture.Text = "$name (Last substring matched by a named group)";
			this.menuItemNamedCapture.Click += new System.EventHandler(this.menuItemNamedCapture_Click);
			// 
			// menuItemLiteralDollarSubstitution
			// 
			this.menuItemLiteralDollarSubstitution.Index = 2;
			this.menuItemLiteralDollarSubstitution.Text = "$$ (Single literal dollar sign)";
			this.menuItemLiteralDollarSubstitution.Click += new System.EventHandler(this.menuItemLiteralDollarSubstitution_Click);
			// 
			// menuItemEntireMatch
			// 
			this.menuItemEntireMatch.Index = 3;
			this.menuItemEntireMatch.Text = "$&& (Entire Match)";
			this.menuItemEntireMatch.Click += new System.EventHandler(this.menuItemEntireMatch_Click);
			// 
			// menuItemBeforeMatch
			// 
			this.menuItemBeforeMatch.Index = 4;
			this.menuItemBeforeMatch.Text = "$` (Input string before the match)";
			this.menuItemBeforeMatch.Click += new System.EventHandler(this.menuItemBeforeMatch_Click);
			// 
			// menuItemAfterMatch
			// 
			this.menuItemAfterMatch.Index = 5;
			this.menuItemAfterMatch.Text = "$\' (Input string after the match)";
			this.menuItemAfterMatch.Click += new System.EventHandler(this.menuItemAfterMatch_Click);
			// 
			// menuItemLastCapture
			// 
			this.menuItemLastCapture.Index = 6;
			this.menuItemLastCapture.Text = "$+ (Last group captured)";
			this.menuItemLastCapture.Click += new System.EventHandler(this.menuItemLastCapture_Click);
			// 
			// menuItemEntireInput
			// 
			this.menuItemEntireInput.Index = 7;
			this.menuItemEntireInput.Text = "$_ (The entire input string)";
			this.menuItemEntireInput.Click += new System.EventHandler(this.menuItemEntireInput_Click);
			// 
			// menuItemRegexReplacementsSeperator2
			// 
			this.menuItemRegexReplacementsSeperator2.Index = 3;
			this.menuItemRegexReplacementsSeperator2.Text = "-";
			// 
			// menuItemRegexReplacementsUndo
			// 
			this.menuItemRegexReplacementsUndo.Index = 4;
			this.menuItemRegexReplacementsUndo.Text = "Undo";
			this.menuItemRegexReplacementsUndo.Click += new System.EventHandler(this.menuItemRegexReplacementsUndo_Click);
			// 
			// menuItemRegexReplacementsCut
			// 
			this.menuItemRegexReplacementsCut.Index = 5;
			this.menuItemRegexReplacementsCut.Text = "Cut";
			this.menuItemRegexReplacementsCut.Click += new System.EventHandler(this.menuItemRegexReplacementsCut_Click);
			// 
			// menuItemRegexReplacementsCopy
			// 
			this.menuItemRegexReplacementsCopy.Index = 6;
			this.menuItemRegexReplacementsCopy.Text = "Copy";
			this.menuItemRegexReplacementsCopy.Click += new System.EventHandler(this.menuItemRegexReplacementsCopy_Click);
			// 
			// menuItemRegExReplacementsPaste
			// 
			this.menuItemRegExReplacementsPaste.Index = 7;
			this.menuItemRegExReplacementsPaste.Text = "Paste";
			this.menuItemRegExReplacementsPaste.Click += new System.EventHandler(this.menuItemRegExReplacementsPaste_Click);
			// 
			// menuItemRegexReplacementsSelectAll
			// 
			this.menuItemRegexReplacementsSelectAll.Index = 8;
			this.menuItemRegexReplacementsSelectAll.Text = "Select All";
			this.menuItemRegexReplacementsSelectAll.Click += new System.EventHandler(this.menuItemRegexReplacementsSelectAll_Click);
			// 
			// txtTestText
			// 
			this.txtTestText.AcceptsReturn = true;
			this.txtTestText.AcceptsTab = true;
			this.txtTestText.AllowDrop = true;
			this.txtTestText.Location = new System.Drawing.Point(184, 296);
			this.txtTestText.Multiline = true;
			this.txtTestText.Name = "txtTestText";
			this.txtTestText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtTestText.Size = new System.Drawing.Size(512, 136);
			this.txtTestText.TabIndex = 4;
			this.txtTestText.Text = "";
			this.toolTip1.SetToolTip(this.txtTestText, "Text that the regular expresion and replacements will be tested against.");
			// 
			// btnCreateMatchReport
			// 
			this.btnCreateMatchReport.Location = new System.Drawing.Point(256, 448);
			this.btnCreateMatchReport.Name = "btnCreateMatchReport";
			this.btnCreateMatchReport.Size = new System.Drawing.Size(128, 23);
			this.btnCreateMatchReport.TabIndex = 5;
			this.btnCreateMatchReport.Text = "Create Match Report";
			this.toolTip1.SetToolTip(this.btnCreateMatchReport, "Click here to create a report that shows the behavior of the regular expression a" +
				"nd replacements.");
			this.btnCreateMatchReport.Click += new System.EventHandler(this.btnCreateMatchReport_Click);
			// 
			// txtMatchReport
			// 
			this.txtMatchReport.AcceptsReturn = true;
			this.txtMatchReport.AcceptsTab = true;
			this.txtMatchReport.AllowDrop = true;
			this.txtMatchReport.Location = new System.Drawing.Point(184, 488);
			this.txtMatchReport.Multiline = true;
			this.txtMatchReport.Name = "txtMatchReport";
			this.txtMatchReport.ReadOnly = true;
			this.txtMatchReport.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtMatchReport.Size = new System.Drawing.Size(512, 168);
			this.txtMatchReport.TabIndex = 6;
			this.txtMatchReport.Text = "";
			this.toolTip1.SetToolTip(this.txtMatchReport, "A report that shows the behavior of the regular expression and any replacements.");
			// 
			// cklRegExOptions
			// 
			this.cklRegExOptions.CheckOnClick = true;
			this.cklRegExOptions.ContextMenu = this.contextMenuRegexOptions;
			this.errorProvider1.SetIconAlignment(this.cklRegExOptions, System.Windows.Forms.ErrorIconAlignment.TopLeft);
			this.errorProvider1.SetIconPadding(this.cklRegExOptions, 10);
			this.cklRegExOptions.Location = new System.Drawing.Point(184, 136);
			this.cklRegExOptions.MultiColumn = true;
			this.cklRegExOptions.Name = "cklRegExOptions";
			this.helpProviderRegexOptions.SetShowHelp(this.cklRegExOptions, true);
			this.cklRegExOptions.Size = new System.Drawing.Size(512, 94);
			this.cklRegExOptions.TabIndex = 2;
			this.toolTip1.SetToolTip(this.cklRegExOptions, "Options supported by .NET Regular Expressions.");
			this.cklRegExOptions.Validating += new System.ComponentModel.CancelEventHandler(this.cklRegExOptions_Validating);
			this.cklRegExOptions.Validated += new System.EventHandler(this.cklRegExOptions_Validated);
			this.cklRegExOptions.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.cklRegExOptions_ItemCheck);
			// 
			// contextMenuRegexOptions
			// 
			this.contextMenuRegexOptions.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																									this.menuItemRegexOptionsHelp});
			// 
			// menuItemRegexOptionsHelp
			// 
			this.menuItemRegexOptionsHelp.Index = 0;
			this.menuItemRegexOptionsHelp.Text = "Help with Regular Expression Options";
			this.menuItemRegexOptionsHelp.Click += new System.EventHandler(this.menuItemRegexOptionsHelp_Click);
			// 
			// lblReplacementExpression
			// 
			this.lblReplacementExpression.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lblReplacementExpression.Location = new System.Drawing.Point(8, 240);
			this.lblReplacementExpression.Name = "lblReplacementExpression";
			this.lblReplacementExpression.Size = new System.Drawing.Size(144, 20);
			this.lblReplacementExpression.TabIndex = 99;
			this.lblReplacementExpression.Text = "Replacement Expression: ";
			this.lblReplacementExpression.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblTestText
			// 
			this.lblTestText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lblTestText.Location = new System.Drawing.Point(16, 296);
			this.lblTestText.Name = "lblTestText";
			this.lblTestText.Size = new System.Drawing.Size(136, 20);
			this.lblTestText.TabIndex = 99;
			this.lblTestText.Text = "Test Text: ";
			this.lblTestText.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblMatchReport
			// 
			this.lblMatchReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lblMatchReport.Location = new System.Drawing.Point(16, 488);
			this.lblMatchReport.Name = "lblMatchReport";
			this.lblMatchReport.Size = new System.Drawing.Size(136, 20);
			this.lblMatchReport.TabIndex = 99;
			this.lblMatchReport.Text = "Match Report:";
			this.lblMatchReport.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblRegExOptions
			// 
			this.lblRegExOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lblRegExOptions.Location = new System.Drawing.Point(16, 136);
			this.lblRegExOptions.Name = "lblRegExOptions";
			this.lblRegExOptions.Size = new System.Drawing.Size(136, 20);
			this.lblRegExOptions.TabIndex = 99;
			this.lblRegExOptions.Text = "Options: ";
			this.lblRegExOptions.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// helpProviderRegexLanguage
			// 
			this.helpProviderRegexLanguage.HelpNamespace = "http://msdn.microsoft.com/library/default.asp?url=/library/en-us/cpgenref/html/cp" +
				"conregularexpressionslanguageelements.asp";
			// 
			// helpProviderRegexOptions
			// 
			this.helpProviderRegexOptions.HelpNamespace = "http://msdn.microsoft.com/library/default.asp?url=/library/en-us/cpref/html/frlrf" +
				"systemtextregularexpressionsregexoptionsclasstopic.asp";
			// 
			// lblIntro
			// 
			this.lblIntro.Location = new System.Drawing.Point(36, 8);
			this.lblIntro.Name = "lblIntro";
			this.lblIntro.Size = new System.Drawing.Size(632, 56);
			this.lblIntro.TabIndex = 100;
			this.lblIntro.Text = @"Regular expressions are complex and sometimes difficult to deal with. This application provides a simple way to immediately see what the behavior of a given regular expression is. You can get help with building regular expressions by right-clicking the text box.";
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// menuItemCaptureCSVElements
			// 
			this.menuItemCaptureCSVElements.Index = 5;
			this.menuItemCaptureCSVElements.Text = "Capture CSV Elements";
			this.menuItemCaptureCSVElements.Click += new System.EventHandler(this.menuItemCaptureCSVElements_Click);
			// 
			// RegularExpressionTester
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(704, 662);
			this.Controls.Add(this.lblIntro);
			this.Controls.Add(this.lblRegExOptions);
			this.Controls.Add(this.cklRegExOptions);
			this.Controls.Add(this.txtMatchReport);
			this.Controls.Add(this.txtTestText);
			this.Controls.Add(this.txtReplacementExpression);
			this.Controls.Add(this.txtRegularExpression);
			this.Controls.Add(this.lblMatchReport);
			this.Controls.Add(this.btnCreateMatchReport);
			this.Controls.Add(this.lblTestText);
			this.Controls.Add(this.lblReplacementExpression);
			this.Controls.Add(this.lblRegularExpression);
			this.Name = "RegularExpressionTester";
			this.Text = ".NET Regular Expression Tester";
			this.Closing += new System.ComponentModel.CancelEventHandler(this.RegularExpressionTester_Closing);
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new RegularExpressionTester());
		}

		private void menuItemBellCharacter_Click(object sender, System.EventArgs e)
		{
			this.txtRegularExpression.SelectedText = "\\a";
		}

		private void menuItemWordBoundary_Click(object sender, System.EventArgs e)
		{
			this.txtRegularExpression.SelectedText = "\\b";
		}

		private void menuItemTab_Click(object sender, System.EventArgs e)
		{
			this.txtRegularExpression.SelectedText = "\\t";
		}

		private void menuItemCarriageReturn_Click(object sender, System.EventArgs e)
		{
			this.txtRegularExpression.SelectedText = "\\r";
		}

		private void menuItemVerticalTab_Click(object sender, System.EventArgs e)
		{
			this.txtRegularExpression.SelectedText = "\\v";
		}

		private void menuItemFormFeed_Click(object sender, System.EventArgs e)
		{
			this.txtRegularExpression.SelectedText = "\\f";
		}

		private void menuItemNewLine_Click(object sender, System.EventArgs e)
		{
			this.txtRegularExpression.SelectedText = "\\n";
		}

		private void menuItemEscapeCharacter_Click(object sender, System.EventArgs e)
		{
			this.txtRegularExpression.SelectedText = "\\e";
		}

		private void menuItemOctalCharacter_Click(object sender, System.EventArgs e)
		{
			this.txtRegularExpression.SelectedText = "\\O";
		}

		private void menuItemHexadecimalCharacter_Click(object sender, System.EventArgs e)
		{
			this.txtRegularExpression.SelectedText = "\\x";
		}

		private void menuItemControlCharacter_Click(object sender, System.EventArgs e)
		{
			this.txtRegularExpression.SelectedText = "\\c";
		}

		private void menuItemUnicodeCharacter_Click(object sender, System.EventArgs e)
		{
			this.txtRegularExpression.SelectedText = "\\u";
		}

		private void menuItemLiteralDot_Click(object sender, System.EventArgs e)
		{
			this.txtRegularExpression.SelectedText = "\\.";		
		}

		private void menuItemLiteralDollar_Click(object sender, System.EventArgs e)
		{
			this.txtRegularExpression.SelectedText = "\\$";
		}

		private void menuItemLiteralCaret_Click(object sender, System.EventArgs e)
		{
			this.txtRegularExpression.SelectedText = "\\^";
		}

		private void menuItemLiteralLeftBrace_Click(object sender, System.EventArgs e)
		{
			this.txtRegularExpression.SelectedText = "\\{";
		}

		private void menuItemLiteralLeftBracket_Click(object sender, System.EventArgs e)
		{
			this.txtRegularExpression.SelectedText = "\\[";
		}

		private void menuItemLiteralLeftParen_Click(object sender, System.EventArgs e)
		{
			this.txtRegularExpression.SelectedText = "\\(";
		}

		private void menuItemLiteralVerticalBar_Click(object sender, System.EventArgs e)
		{
			this.txtRegularExpression.SelectedText = "\\|";
		}

		private void menuItemLiteralRightParen_Click(object sender, System.EventArgs e)
		{
			this.txtRegularExpression.SelectedText = "\\)";		
		}

		private void menuItemLiteralAsterisk_Click(object sender, System.EventArgs e)
		{
			this.txtRegularExpression.SelectedText = "\\*";
		}

		private void menuItemLiteralPlus_Click(object sender, System.EventArgs e)
		{
			this.txtRegularExpression.SelectedText = "\\+";
		}

		private void menuItemLiteralQuestionMark_Click(object sender, System.EventArgs e)
		{
			this.txtRegularExpression.SelectedText = "\\?";
		}

		private void menuItemLiteralDash_Click(object sender, System.EventArgs e)
		{
			this.txtRegularExpression.SelectedText = "\\-";
		}

		private void menuItemLiteralNumberSign_Click(object sender, System.EventArgs e)
		{
			this.txtRegularExpression.SelectedText = "\\#";
		}

		private void menuItemNumberedCapture_Click(object sender, System.EventArgs e)
		{
			this.txtRegularExpression.SelectedText = "$number";
			this.txtRegularExpression.SelectionStart -= 6;
			this.txtRegularExpression.SelectionLength = 6;
		}

		private void menuItemNamedCapture_Click(object sender, System.EventArgs e)
		{
			this.txtRegularExpression.SelectedText = "$name";
			this.txtRegularExpression.SelectionStart -= 4;
			this.txtRegularExpression.SelectionLength = 4;
		}

		private void menuItemLiteralDollarSubstitution_Click(object sender, System.EventArgs e)
		{
			this.txtRegularExpression.SelectedText = "$$";		
		}

		private void menuItemEntireMatch_Click(object sender, System.EventArgs e)
		{
			this.txtRegularExpression.SelectedText = "$&";
		}

		private void menuItemBeforeMatch_Click(object sender, System.EventArgs e)
		{
			this.txtRegularExpression.SelectedText = "$`";
		}

		private void menuItemAfterMatch_Click(object sender, System.EventArgs e)
		{
			this.txtRegularExpression.SelectedText = "$'";
		}

		private void menuItemLastCapture_Click(object sender, System.EventArgs e)
		{
			this.txtRegularExpression.SelectedText = "$+";
		}

		private void menuItemEntireInput_Click(object sender, System.EventArgs e)
		{
			this.txtRegularExpression.SelectedText = "$_";
		}

		private void menuItemAnyCharacter_Click(object sender, System.EventArgs e)
		{
			this.txtRegularExpression.SelectedText = ".";
		}

		private void menuItemAnyCharacterInSet_Click(object sender, System.EventArgs e)
		{
			this.txtRegularExpression.SelectedText = "[aeiou]";
			this.txtRegularExpression.SelectionStart -= 6;
			this.txtRegularExpression.SelectionLength = 5;
		}

		private void menuItemAnyCharacterNotInSet_Click(object sender, System.EventArgs e)
		{
			this.txtRegularExpression.SelectedText = "[^aeiou]";
			this.txtRegularExpression.SelectionStart -= 6;
			this.txtRegularExpression.SelectionLength = 5;
		}

		private void menuItemCharacterRange_Click(object sender, System.EventArgs e)
		{
			this.txtRegularExpression.SelectedText = "-";
		}

		private void menuItemCharacterInNamedUnicodeBlock_Click(object sender, System.EventArgs e)
		{
			this.txtRegularExpression.SelectedText = "\\p{name}";
			this.txtRegularExpression.SelectionStart -= 5;
			this.txtRegularExpression.SelectionLength = 4;
		}

		private void menuItemCharacterNotInNamedUnicodeBlock_Click(object sender, System.EventArgs e)
		{
			this.txtRegularExpression.SelectedText = "\\P{name}";
			this.txtRegularExpression.SelectionStart -= 5;
			this.txtRegularExpression.SelectionLength = 4;
		}

		private void menuItemAnyWordCharacter_Click(object sender, System.EventArgs e)
		{
			this.txtRegularExpression.SelectedText = "\\w";
		}

		private void menuItemAnyNonWordCharacter_Click(object sender, System.EventArgs e)
		{
			this.txtRegularExpression.SelectedText = "\\W";
		}

		private void menuItemAnyWhitespaceCharacter_Click(object sender, System.EventArgs e)
		{
			this.txtRegularExpression.SelectedText = "\\s";
		}

		private void menuItemAnyNonWhitespaceCharacter_Click(object sender, System.EventArgs e)
		{
			this.txtRegularExpression.SelectedText = "\\S";
		}

		private void menuItemAnyDecimalDigit_Click(object sender, System.EventArgs e)
		{
			this.txtRegularExpression.SelectedText = "\\d";
		}

		private void menuItemAnyNonDigit_Click(object sender, System.EventArgs e)
		{
			this.txtRegularExpression.SelectedText = "\\D";
		}

		private void menuItemLineBegin_Click(object sender, System.EventArgs e)
		{
			this.txtRegularExpression.SelectedText = "^";
		}

		private void menuItemLineEnd_Click(object sender, System.EventArgs e)
		{
			this.txtRegularExpression.SelectedText = "$";
		}

		private void menuItemStringBegin_Click(object sender, System.EventArgs e)
		{
			this.txtRegularExpression.SelectedText = "\\A";
		}

		private void menuItemStrinEndNonCR_Click(object sender, System.EventArgs e)
		{
			this.txtRegularExpression.SelectedText = "\\Z";
		}

		private void menuItemStringEnd_Click(object sender, System.EventArgs e)
		{
			this.txtRegularExpression.SelectedText = "\\z";
		}

		private void menuItemPreviousMatchEnd_Click(object sender, System.EventArgs e)
		{
			this.txtRegularExpression.SelectedText = "\\G";
		}

		private void menuItemWordBoundary2_Click(object sender, System.EventArgs e)
		{
			this.txtRegularExpression.SelectedText = "\\b";
		}

		private void menuItemNonWordBoundary_Click(object sender, System.EventArgs e)
		{
			this.txtRegularExpression.SelectedText = "\\B";
		}

		private void menuItemStarQuantifier_Click(object sender, System.EventArgs e)
		{
			this.txtRegularExpression.SelectedText = "*";
		}

		private void menuItemPlusQuantifier_Click(object sender, System.EventArgs e)
		{
			this.txtRegularExpression.SelectedText = "+";
		}

		private void menuItemQuestionMarkQuantifier_Click(object sender, System.EventArgs e)
		{
			this.txtRegularExpression.SelectedText = "?";
		}

		private void menuItemExactQuantifier_Click(object sender, System.EventArgs e)
		{
			this.txtRegularExpression.SelectedText = "{n}";
			this.txtRegularExpression.SelectionStart -= 2;
			this.txtRegularExpression.SelectionLength = 1;
		}

		private void menuItemAtLeastQuantifier_Click(object sender, System.EventArgs e)
		{
			this.txtRegularExpression.SelectedText = "{n,}";
			this.txtRegularExpression.SelectionStart -= 3;
			this.txtRegularExpression.SelectionLength = 1;
		}

		private void menuItemAtLeastButNotMoreQuantifier_Click(object sender, System.EventArgs e)
		{
			this.txtRegularExpression.SelectedText = "{n,m}";
			this.txtRegularExpression.SelectionStart -= 4;
			this.txtRegularExpression.SelectionLength = 3;
		}

		private void menuItemMatchFewestModifier_Click(object sender, System.EventArgs e)
		{
			this.txtRegularExpression.SelectedText = "?";
		}

		private void menuItemAutoNumberedCaptureGroup_Click(object sender, System.EventArgs e)
		{
			this.txtRegularExpression.SelectedText = "(expression)";
			this.txtRegularExpression.SelectionStart -= 11;
			this.txtRegularExpression.SelectionLength = 10;
		}

		private void menuItemNamedCaptureGroup_Click(object sender, System.EventArgs e)
		{
			this.txtRegularExpression.SelectedText = "(?<name>expression)";
			this.txtRegularExpression.SelectionStart -= 16;
			this.txtRegularExpression.SelectionLength = 4;
		}

		private void menuItemBalancingCaptureGroup_Click(object sender, System.EventArgs e)
		{
			this.txtRegularExpression.SelectedText = "(?<name1-name2>expression)";
			this.txtRegularExpression.SelectionStart -= 23;
			this.txtRegularExpression.SelectionLength = 4;
		}

		private void menuItemNonCapturingGroup_Click(object sender, System.EventArgs e)
		{
			this.txtRegularExpression.SelectedText = "(?:expression)";
			this.txtRegularExpression.SelectionStart -= 11;
			this.txtRegularExpression.SelectionLength = 10;
		}

		private void menuItemOptionControlGroup_Click(object sender, System.EventArgs e)
		{
			this.txtRegularExpression.SelectedText = "(?imnsx-imnsx:expression)";
			this.txtRegularExpression.SelectionStart -= 23;
			this.txtRegularExpression.SelectionLength = 11;
		}

		private void menuItemZeroWidthPositiveLookahead_Click(object sender, System.EventArgs e)
		{
			this.txtRegularExpression.SelectedText = "(?=expression)";
			this.txtRegularExpression.SelectionStart -= 11;
			this.txtRegularExpression.SelectionLength = 10;
		}

		private void menuItemZeroWidthNegativeLookahead_Click(object sender, System.EventArgs e)
		{
			this.txtRegularExpression.SelectedText = "(?!expression)";
			this.txtRegularExpression.SelectionStart -= 11;
			this.txtRegularExpression.SelectionLength = 10;
		}

		private void menuItemZeroWidthPositiveLookbehind_Click(object sender, System.EventArgs e)
		{
			this.txtRegularExpression.SelectedText = "(?<=expression)";
			this.txtRegularExpression.SelectionStart -= 11;
			this.txtRegularExpression.SelectionLength = 10;
		}

		private void menuItemZeroWidthNegativeLookbehind_Click(object sender, System.EventArgs e)
		{
			this.txtRegularExpression.SelectedText = "(?<!expression)";
			this.txtRegularExpression.SelectionStart -= 11;
			this.txtRegularExpression.SelectionLength = 10;
		}

		private void menuItemNonBacktrackingSubexpression_Click(object sender, System.EventArgs e)
		{
			this.txtRegularExpression.SelectedText = "(?>expression)";
			this.txtRegularExpression.SelectionStart -= 11;
			this.txtRegularExpression.SelectionLength = 10;
		}

		private void menuItemBackreference_Click(object sender, System.EventArgs e)
		{
			this.txtRegularExpression.SelectedText = "\\number";
			this.txtRegularExpression.SelectionStart -= 6;
			this.txtRegularExpression.SelectionLength = 6;
		}

		private void menuItemNamedBackreference_Click(object sender, System.EventArgs e)
		{
			this.txtRegularExpression.SelectedText = "\\k<name>";
			this.txtRegularExpression.SelectionStart -= 5;
			this.txtRegularExpression.SelectionLength = 4;
		}

		private void menuItemOrAlternation_Click(object sender, System.EventArgs e)
		{
			this.txtRegularExpression.SelectedText = "|";
		}

		private void menuItemYesNoAlternation_Click(object sender, System.EventArgs e)
		{
			this.txtRegularExpression.SelectedText = "(?(?=expression)yes|no)";
			this.txtRegularExpression.SelectionStart -= 18;
			this.txtRegularExpression.SelectionLength = 10;
		}

		private void menuItemNamedYesNoAlternation_Click(object sender, System.EventArgs e)
		{
			this.txtRegularExpression.SelectedText = "(?(name)yes|no)";
			this.txtRegularExpression.SelectionStart -= 12;
			this.txtRegularExpression.SelectionLength = 4;
		}

		private void menuItemInlineComment_Click(object sender, System.EventArgs e)
		{
			this.txtRegularExpression.SelectedText = "(?#comment)";
			this.txtRegularExpression.SelectionStart -= 8;
			this.txtRegularExpression.SelectionLength = 7;
		}

		private void menuItemXModeComment_Click(object sender, System.EventArgs e)
		{
			this.txtRegularExpression.SelectedText = "#comment";
			this.txtRegularExpression.SelectionStart -= 7;
			this.txtRegularExpression.SelectionLength = 7;
		}

		private void menuItemRegexHelp_Click(object sender, EventArgs e)
		{
			System.Diagnostics.Process.Start("IExplore", "http://msdn.microsoft.com/library/default.asp?url=/library/en-us/cpgenref/html/cpconregularexpressionslanguageelements.asp");
		}

		private void menuItemRegexOptionsHelp_Click(object sender, EventArgs e)
		{
			System.Diagnostics.Process.Start("IExplore", "http://msdn.microsoft.com/library/default.asp?url=/library/en-us/cpref/html/frlrfsystemtextregularexpressionsregexoptionsclasstopic.asp");
		}

		private void menuItemRegexReplacementsHelp_Click(object sender, System.EventArgs e)
		{
			System.Diagnostics.Process.Start("IExplore", "http://msdn.microsoft.com/library/default.asp?url=/library/en-us/cpgenref/html/cpconregularexpressionslanguageelements.asp");		
		}

		private void menuItemUSPhoneRegex_Click(object sender, System.EventArgs e)
		{
			this.txtRegularExpression.Text = @"^[01]?[- .]?(\([2-9]\d{2}\)|[2-9]\d{2})[- .]?\d{3}[- .]?\d{4}$";
		}

		private void menuItemUSZipRegex_Click(object sender, System.EventArgs e)
		{
			this.txtRegularExpression.Text = @"^(\d{5}-\d{4}|\d{5}|\d{9})$|^([a-zA-Z]\d[a-zA-Z] \d[a-zA-Z]\d)$";		
		}

		private void menuItemEmailRegex_Click(object sender, System.EventArgs e)
		{
			this.txtRegularExpression.Text = @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
		}

		private void menuItemWebURLRegex_Click(object sender, System.EventArgs e)
		{
			this.txtRegularExpression.Text = @"^(ht|f)tp(s?)\:\/\/[0-9a-zA-Z]([-.\w]*[0-9a-zA-Z])*(:(0-9)*)*(\/?)([a-zA-Z0-9\-\.\?\,\'\/\\\+&amp;%\$#_]*)?$";
		}

		private void menuItemTrimWhitespace_Click(object sender, System.EventArgs e)
		{
			this.txtRegularExpression.Text = @"^[\s\t]*([^\s\t].*?)[\s\t]*$";
		}

		private void menuItemCaptureCSVElements_Click(object sender, System.EventArgs e)
		{
			this.txtRegularExpression.Text = "^(?:(\\d+|\"(?:\"\"|.)+?\")(?:,|$))*";
		}

		private void menuItemRegexUndo_Click(object sender, System.EventArgs e)
		{
			this.txtRegularExpression.Undo();
		}

		private void menuItemRegexCut_Click(object sender, System.EventArgs e)
		{
			this.txtRegularExpression.Cut();
		}

		private void menuItemRegexCopy_Click(object sender, System.EventArgs e)
		{
			this.txtRegularExpression.Copy();
		}

		private void menuItemRegexPaste_Click(object sender, System.EventArgs e)
		{
			this.txtRegularExpression.Paste();
		}

		private void menuItemRegexSelectAll_Click(object sender, System.EventArgs e)
		{
			this.txtRegularExpression.SelectAll();
		}

		private void menuItemRegexReplacementsUndo_Click(object sender, System.EventArgs e)
		{
			this.txtReplacementExpression.Undo();
		}

		private void menuItemRegexReplacementsCut_Click(object sender, System.EventArgs e)
		{
			this.txtReplacementExpression.Cut();
		}

		private void menuItemRegexReplacementsCopy_Click(object sender, System.EventArgs e)
		{
			this.txtReplacementExpression.Copy();
		}

		private void menuItemRegExReplacementsPaste_Click(object sender, System.EventArgs e)
		{
			this.txtReplacementExpression.Paste();
		}

		private void menuItemRegexReplacementsSelectAll_Click(object sender, System.EventArgs e)
		{
			this.txtReplacementExpression.SelectAll();
		}

		/// <summary>
		/// Create the report on the regular expression and replacement expression behavior.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnCreateMatchReport_Click(object sender, System.EventArgs e)
		{
			this.txtMatchReport.Text = "";

			RegexOptions objOptions = RegexOptions.None;

			foreach (object objItem in this.cklRegExOptions.CheckedItems)
			{
				objOptions = objOptions | (RegexOptions) System.Enum.Parse(typeof(RegexOptions), this.cklRegExOptions.GetItemText(objItem));
			}

			Regex rgxTest;
			
			try
			{
				rgxTest = new Regex(this.txtRegularExpression.Text, objOptions);
			}
			catch (Exception ex)
			{
				this.txtMatchReport.Text = "Error: " + ex.GetBaseException().Message + "\r\n";
				return;
			}

			if (rgxTest.IsMatch(this.txtTestText.Text))
			{
				MatchCollection rgxMatches = rgxTest.Matches(this.txtTestText.Text);
				this.txtMatchReport.Text += "Found " + rgxMatches.Count + " match(es):\r\n";

				for (int i = 0; i < rgxMatches.Count; i++)
				{
					this.txtMatchReport.Text += "\tMatch " + i + ": " + rgxMatches[i].Value + "\r\n";

					GroupCollection rgxGroups = rgxMatches[i].Groups;

					for (int j = 0; j < rgxGroups.Count; j++)
					{
						this.txtMatchReport.Text += "\t\tGroup " + j + ": " + rgxGroups[j].Value + "\r\n";

						CaptureCollection rgxCaptures = rgxGroups[j].Captures;

						for (int k = 0; k < rgxCaptures.Count; k++)
						{
							this.txtMatchReport.Text += "\t\t\tCapture " + k + ": " + rgxCaptures[k].Value + "\r\n";
						}
					}
				}
				
				this.txtMatchReport.Text += "\r\n";

				if (this.txtReplacementExpression.TextLength > 0)
				{
					this.txtMatchReport.Text += "Replacement result: " + rgxTest.Replace(this.txtTestText.Text, this.txtReplacementExpression.Text) + "\r\n";
					this.txtMatchReport.Text += "\r\n";
				}
			}
			else
			{
				this.txtMatchReport.Text += "No matches found.\r\n\r\n";
			}
		}

		/// <summary>
		/// If IgnorePatternWhiteSpace is checked then allow returns and tabs in the regular expression text box.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void cklRegExOptions_ItemCheck(object sender, ItemCheckEventArgs e)
		{
			if (this.cklRegExOptions.FindString("IgnorePatternWhitespace") == e.Index)
			{
				this.txtRegularExpression.AcceptsReturn = (e.NewValue == CheckState.Checked);
				this.txtRegularExpression.AcceptsTab = (e.NewValue == CheckState.Checked);
			}
		}

		/// <summary>
		/// Validate that no illegal combinations of Options were checked.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void cklRegExOptions_Validating(object sender, CancelEventArgs e)
		{
			if (this.cklRegExOptions.CheckedItems.Count == 0)
			{
				this.cklRegExOptions.SetItemChecked(this.cklRegExOptions.Items.IndexOf("None"), true);
			}

			if (this.cklRegExOptions.CheckedItems.Count > 1)
			{
				if (this.cklRegExOptions.CheckedItems.Contains("None"))
				{
					this.cklRegExOptions.SetItemChecked(this.cklRegExOptions.Items.IndexOf("None"), false);
				}
				else if (this.cklRegExOptions.CheckedItems.Contains("ECMAScript"))
				{
					foreach (object objItem in cklRegExOptions.CheckedItems)
					{
						switch (this.cklRegExOptions.GetItemText(objItem))
						{
							case "ECMAScript":
							case "IgnoreCase":
							case "Multiline":
							case "Compiled":
								break;

							default:
								this.errorProvider1.SetError(this.cklRegExOptions, "When ECMAScript is selected, you may only select IgnoreCase, Multiline, and Compiled.");
								e.Cancel = true;
								break;
						}
					}
				}
			}
		}

		/// <summary>
		/// Clear the error provider if validation passed for the Options.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void cklRegExOptions_Validated(object sender, EventArgs e)
		{
			// If all conditions have been met, clear the ErrorProvider of errors.
			this.errorProvider1.SetError(this.cklRegExOptions, "");
		}

/// <summary>
/// Catch the closing event and override the cancel value so that the form can close even if validation failed.
/// </summary>
/// <param name="sender"></param>
/// <param name="e"></param>
		private void RegularExpressionTester_Closing(object sender, CancelEventArgs e)
		{
			e.Cancel = false;
		}

	}
}
