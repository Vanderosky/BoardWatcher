#pragma checksum "C:\Users\Vander\Documents\Programming\C#\BoardWatcher\Pages\Chess.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cf8c0489fef089cfd321057112a356ce8173f93b"
// <auto-generated/>
#pragma warning disable 1591
namespace BoardWatcher.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Vander\Documents\Programming\C#\BoardWatcher\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Vander\Documents\Programming\C#\BoardWatcher\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Vander\Documents\Programming\C#\BoardWatcher\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Vander\Documents\Programming\C#\BoardWatcher\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Vander\Documents\Programming\C#\BoardWatcher\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Vander\Documents\Programming\C#\BoardWatcher\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Vander\Documents\Programming\C#\BoardWatcher\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Vander\Documents\Programming\C#\BoardWatcher\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Vander\Documents\Programming\C#\BoardWatcher\_Imports.razor"
using BoardWatcher;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Vander\Documents\Programming\C#\BoardWatcher\_Imports.razor"
using BoardWatcher.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Vander\Documents\Programming\C#\BoardWatcher\Pages\Chess.razor"
using BoardWatcher.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/chess")]
    public partial class Chess : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 7 "C:\Users\Vander\Documents\Programming\C#\BoardWatcher\Pages\Chess.razor"
 if (gameBoard == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(0, "<p b-n0nxo8uhw8><em b-n0nxo8uhw8>Loading...</em></p>");
#nullable restore
#line 10 "C:\Users\Vander\Documents\Programming\C#\BoardWatcher\Pages\Chess.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "flex-container");
            __builder.AddAttribute(3, "b-n0nxo8uhw8");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "flex-child");
            __builder.AddAttribute(6, "b-n0nxo8uhw8");
            __builder.OpenElement(7, "table");
            __builder.AddAttribute(8, "class", "chess-board");
            __builder.AddAttribute(9, "b-n0nxo8uhw8");
            __builder.OpenElement(10, "tbody");
            __builder.AddAttribute(11, "b-n0nxo8uhw8");
            __builder.AddMarkupContent(12, @"<tr b-n0nxo8uhw8><th b-n0nxo8uhw8></th>
                        <th b-n0nxo8uhw8>a</th>
                        <th b-n0nxo8uhw8>b</th>
                        <th b-n0nxo8uhw8>c</th>
                        <th b-n0nxo8uhw8>d</th>
                        <th b-n0nxo8uhw8>e</th>
                        <th b-n0nxo8uhw8>f</th>
                        <th b-n0nxo8uhw8>g</th>
                        <th b-n0nxo8uhw8>h</th></tr>

                    ");
            __builder.OpenElement(13, "tr");
            __builder.AddAttribute(14, "b-n0nxo8uhw8");
            __builder.AddMarkupContent(15, "<th b-n0nxo8uhw8>8</th>");
#nullable restore
#line 31 "C:\Users\Vander\Documents\Programming\C#\BoardWatcher\Pages\Chess.razor"
                         for (var i = 0; i < 8; i++)
                        {
                            if (i % 2 == 0)
                            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(16, "td");
            __builder.AddAttribute(17, "class", "light");
            __builder.AddAttribute(18, "b-n0nxo8uhw8");
            __builder.AddContent(19, 
#nullable restore
#line 35 "C:\Users\Vander\Documents\Programming\C#\BoardWatcher\Pages\Chess.razor"
                                                   GetPiece(gameBoard[0 + i])

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.OpenElement(20, "td");
            __builder.AddAttribute(21, "class", "dark");
            __builder.AddAttribute(22, "b-n0nxo8uhw8");
            __builder.AddContent(23, 
#nullable restore
#line 35 "C:\Users\Vander\Documents\Programming\C#\BoardWatcher\Pages\Chess.razor"
                                                                                                             GetPiece(gameBoard[1 +
                    i])

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 37 "C:\Users\Vander\Documents\Programming\C#\BoardWatcher\Pages\Chess.razor"
                            }
                        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n                    ");
            __builder.OpenElement(25, "tr");
            __builder.AddAttribute(26, "b-n0nxo8uhw8");
            __builder.AddMarkupContent(27, "<th b-n0nxo8uhw8>7</th>");
#nullable restore
#line 42 "C:\Users\Vander\Documents\Programming\C#\BoardWatcher\Pages\Chess.razor"
                         for (var i = 0; i < 8; i++)
                        {
                            if (i % 2 == 0)
                            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(28, "td");
            __builder.AddAttribute(29, "class", "dark");
            __builder.AddAttribute(30, "b-n0nxo8uhw8");
            __builder.AddContent(31, 
#nullable restore
#line 46 "C:\Users\Vander\Documents\Programming\C#\BoardWatcher\Pages\Chess.razor"
                                                  GetPiece(gameBoard[8 + i])

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.OpenElement(32, "td");
            __builder.AddAttribute(33, "class", "light");
            __builder.AddAttribute(34, "b-n0nxo8uhw8");
            __builder.AddContent(35, 
#nullable restore
#line 46 "C:\Users\Vander\Documents\Programming\C#\BoardWatcher\Pages\Chess.razor"
                                                                                                             GetPiece(gameBoard[9 +
                    i])

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 48 "C:\Users\Vander\Documents\Programming\C#\BoardWatcher\Pages\Chess.razor"
                            }
                        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n                    ");
            __builder.OpenElement(37, "tr");
            __builder.AddAttribute(38, "b-n0nxo8uhw8");
            __builder.AddMarkupContent(39, "<th b-n0nxo8uhw8>6</th>");
#nullable restore
#line 53 "C:\Users\Vander\Documents\Programming\C#\BoardWatcher\Pages\Chess.razor"
                         for (var i = 0; i < 8; i++)
                        {
                            if (i % 2 == 0)
                            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(40, "td");
            __builder.AddAttribute(41, "class", "light");
            __builder.AddAttribute(42, "b-n0nxo8uhw8");
            __builder.AddContent(43, 
#nullable restore
#line 57 "C:\Users\Vander\Documents\Programming\C#\BoardWatcher\Pages\Chess.razor"
                                                   GetPiece(gameBoard[16 + i])

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.OpenElement(44, "td");
            __builder.AddAttribute(45, "class", "dark");
            __builder.AddAttribute(46, "b-n0nxo8uhw8");
            __builder.AddContent(47, 
#nullable restore
#line 57 "C:\Users\Vander\Documents\Programming\C#\BoardWatcher\Pages\Chess.razor"
                                                                                                              GetPiece(gameBoard[17
                    + i])

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 59 "C:\Users\Vander\Documents\Programming\C#\BoardWatcher\Pages\Chess.razor"
                            }
                        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n                    ");
            __builder.OpenElement(49, "tr");
            __builder.AddAttribute(50, "b-n0nxo8uhw8");
            __builder.AddMarkupContent(51, "<th b-n0nxo8uhw8>5</th>");
#nullable restore
#line 64 "C:\Users\Vander\Documents\Programming\C#\BoardWatcher\Pages\Chess.razor"
                         for (var i = 0; i < 8; i++)
                        {
                            if (i % 2 == 0)
                            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(52, "td");
            __builder.AddAttribute(53, "class", "dark");
            __builder.AddAttribute(54, "b-n0nxo8uhw8");
            __builder.AddContent(55, 
#nullable restore
#line 68 "C:\Users\Vander\Documents\Programming\C#\BoardWatcher\Pages\Chess.razor"
                                                  GetPiece(gameBoard[24 + i])

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.OpenElement(56, "td");
            __builder.AddAttribute(57, "class", "light");
            __builder.AddAttribute(58, "b-n0nxo8uhw8");
            __builder.AddContent(59, 
#nullable restore
#line 68 "C:\Users\Vander\Documents\Programming\C#\BoardWatcher\Pages\Chess.razor"
                                                                                                              GetPiece(gameBoard[25
                    + i])

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 70 "C:\Users\Vander\Documents\Programming\C#\BoardWatcher\Pages\Chess.razor"
                            }
                        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(60, "\r\n                    ");
            __builder.OpenElement(61, "tr");
            __builder.AddAttribute(62, "b-n0nxo8uhw8");
            __builder.AddMarkupContent(63, "<th b-n0nxo8uhw8>4</th>");
#nullable restore
#line 75 "C:\Users\Vander\Documents\Programming\C#\BoardWatcher\Pages\Chess.razor"
                         for (var i = 0; i < 8; i++)
                        {
                            if (i % 2 == 0)
                            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(64, "td");
            __builder.AddAttribute(65, "class", "light");
            __builder.AddAttribute(66, "b-n0nxo8uhw8");
            __builder.AddContent(67, 
#nullable restore
#line 79 "C:\Users\Vander\Documents\Programming\C#\BoardWatcher\Pages\Chess.razor"
                                                   GetPiece(gameBoard[32 + i])

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.OpenElement(68, "td");
            __builder.AddAttribute(69, "class", "dark");
            __builder.AddAttribute(70, "b-n0nxo8uhw8");
            __builder.AddContent(71, 
#nullable restore
#line 79 "C:\Users\Vander\Documents\Programming\C#\BoardWatcher\Pages\Chess.razor"
                                                                                                              GetPiece(gameBoard[33
                    + i])

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 81 "C:\Users\Vander\Documents\Programming\C#\BoardWatcher\Pages\Chess.razor"
                            }
                        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(72, "\r\n                    ");
            __builder.OpenElement(73, "tr");
            __builder.AddAttribute(74, "b-n0nxo8uhw8");
            __builder.AddMarkupContent(75, "<th b-n0nxo8uhw8>3</th>");
#nullable restore
#line 86 "C:\Users\Vander\Documents\Programming\C#\BoardWatcher\Pages\Chess.razor"
                         for (var i = 0; i < 8; i++)
                        {
                            if (i % 2 == 0)
                            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(76, "td");
            __builder.AddAttribute(77, "class", "dark");
            __builder.AddAttribute(78, "b-n0nxo8uhw8");
            __builder.AddContent(79, 
#nullable restore
#line 90 "C:\Users\Vander\Documents\Programming\C#\BoardWatcher\Pages\Chess.razor"
                                                  GetPiece(gameBoard[40 + i])

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.OpenElement(80, "td");
            __builder.AddAttribute(81, "class", "light");
            __builder.AddAttribute(82, "b-n0nxo8uhw8");
            __builder.AddContent(83, 
#nullable restore
#line 90 "C:\Users\Vander\Documents\Programming\C#\BoardWatcher\Pages\Chess.razor"
                                                                                                              GetPiece(gameBoard[41
                    + i])

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 92 "C:\Users\Vander\Documents\Programming\C#\BoardWatcher\Pages\Chess.razor"
                            }
                        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(84, "\r\n                    ");
            __builder.OpenElement(85, "tr");
            __builder.AddAttribute(86, "b-n0nxo8uhw8");
            __builder.AddMarkupContent(87, "<th b-n0nxo8uhw8>2</th>");
#nullable restore
#line 97 "C:\Users\Vander\Documents\Programming\C#\BoardWatcher\Pages\Chess.razor"
                         for (var i = 0; i < 8; i++)
                        {
                            if (i % 2 == 0)
                            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(88, "td");
            __builder.AddAttribute(89, "class", "light");
            __builder.AddAttribute(90, "b-n0nxo8uhw8");
            __builder.AddContent(91, 
#nullable restore
#line 101 "C:\Users\Vander\Documents\Programming\C#\BoardWatcher\Pages\Chess.razor"
                                                   GetPiece(gameBoard[48 + i])

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.OpenElement(92, "td");
            __builder.AddAttribute(93, "class", "dark");
            __builder.AddAttribute(94, "b-n0nxo8uhw8");
            __builder.AddContent(95, 
#nullable restore
#line 101 "C:\Users\Vander\Documents\Programming\C#\BoardWatcher\Pages\Chess.razor"
                                                                                                              GetPiece(gameBoard[49
                    + i])

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 103 "C:\Users\Vander\Documents\Programming\C#\BoardWatcher\Pages\Chess.razor"
                            }
                        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(96, "\r\n                    ");
            __builder.OpenElement(97, "tr");
            __builder.AddAttribute(98, "b-n0nxo8uhw8");
            __builder.AddMarkupContent(99, "<th b-n0nxo8uhw8>1</th>");
#nullable restore
#line 108 "C:\Users\Vander\Documents\Programming\C#\BoardWatcher\Pages\Chess.razor"
                         for (var i = 0; i < 8; i++)
                        {
                            if (i % 2 == 0)
                            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(100, "td");
            __builder.AddAttribute(101, "class", "dark");
            __builder.AddAttribute(102, "b-n0nxo8uhw8");
            __builder.AddContent(103, 
#nullable restore
#line 112 "C:\Users\Vander\Documents\Programming\C#\BoardWatcher\Pages\Chess.razor"
                                                  GetPiece(gameBoard[56 + i])

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.OpenElement(104, "td");
            __builder.AddAttribute(105, "class", "light");
            __builder.AddAttribute(106, "b-n0nxo8uhw8");
            __builder.AddContent(107, 
#nullable restore
#line 112 "C:\Users\Vander\Documents\Programming\C#\BoardWatcher\Pages\Chess.razor"
                                                                                                              GetPiece(gameBoard[57
                    + i])

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 114 "C:\Users\Vander\Documents\Programming\C#\BoardWatcher\Pages\Chess.razor"
                            }
                        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(108, "\r\n            ");
            __builder.OpenElement(109, "div");
            __builder.AddAttribute(110, "class", "stateMenu");
            __builder.AddAttribute(111, "b-n0nxo8uhw8");
            __builder.AddMarkupContent(112, "<button class=\"btn btn-primary\" b-n0nxo8uhw8><span class=\"oi oi-media-skip-backward\" aria-hidden=\"true\" b-n0nxo8uhw8></span></button>\r\n                ");
            __builder.OpenElement(113, "button");
            __builder.AddAttribute(114, "class", "btn btn-primary");
            __builder.AddAttribute(115, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 121 "C:\Users\Vander\Documents\Programming\C#\BoardWatcher\Pages\Chess.razor"
                                                          moveBackwards

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(116, "b-n0nxo8uhw8");
            __builder.AddMarkupContent(117, "<span class=\"oi oi-media-step-backward\" aria-hidden=\"true\" b-n0nxo8uhw8></span>");
            __builder.CloseElement();
            __builder.AddMarkupContent(118, "\r\n                ");
            __builder.OpenElement(119, "button");
            __builder.AddAttribute(120, "class", "btn btn-primary");
            __builder.AddAttribute(121, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 123 "C:\Users\Vander\Documents\Programming\C#\BoardWatcher\Pages\Chess.razor"
                                                          moveForward

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(122, "b-n0nxo8uhw8");
            __builder.AddMarkupContent(123, "<span class=\"oi oi-media-step-forward\" aria-hidden=\"true\" b-n0nxo8uhw8></span>");
            __builder.CloseElement();
            __builder.AddMarkupContent(124, "\r\n                ");
            __builder.AddMarkupContent(125, "<button class=\"btn btn-primary\" b-n0nxo8uhw8><span class=\"oi oi-media-skip-forward\" aria-hidden=\"true\" b-n0nxo8uhw8></span></button>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(126, "\r\n        ");
            __builder.OpenElement(127, "div");
            __builder.AddAttribute(128, "class", "flex-child");
            __builder.AddAttribute(129, "b-n0nxo8uhw8");
            __builder.OpenElement(130, "table");
            __builder.AddAttribute(131, "class", "table");
            __builder.AddAttribute(132, "b-n0nxo8uhw8");
            __builder.AddMarkupContent(133, "<thead b-n0nxo8uhw8><tr b-n0nxo8uhw8><th b-n0nxo8uhw8>Move</th>\r\n                    <th b-n0nxo8uhw8>Whites</th>\r\n                    <th b-n0nxo8uhw8>Blacks</th></tr></thead>\r\n            ");
            __builder.OpenElement(134, "tbody");
            __builder.AddAttribute(135, "b-n0nxo8uhw8");
#nullable restore
#line 138 "C:\Users\Vander\Documents\Programming\C#\BoardWatcher\Pages\Chess.razor"
             for (int index = 0; index < MovesHistory.Length; index++)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(136, "tr");
            __builder.AddAttribute(137, "b-n0nxo8uhw8");
            __builder.OpenElement(138, "td");
            __builder.AddAttribute(139, "b-n0nxo8uhw8");
            __builder.AddContent(140, 
#nullable restore
#line 141 "C:\Users\Vander\Documents\Programming\C#\BoardWatcher\Pages\Chess.razor"
                         index

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(141, "\r\n                    ");
            __builder.OpenElement(142, "td");
            __builder.AddAttribute(143, "b-n0nxo8uhw8");
            __builder.AddContent(144, 
#nullable restore
#line 142 "C:\Users\Vander\Documents\Programming\C#\BoardWatcher\Pages\Chess.razor"
                         getMoveInNotation(MovesHistory[index])

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 144 "C:\Users\Vander\Documents\Programming\C#\BoardWatcher\Pages\Chess.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 149 "C:\Users\Vander\Documents\Programming\C#\BoardWatcher\Pages\Chess.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 151 "C:\Users\Vander\Documents\Programming\C#\BoardWatcher\Pages\Chess.razor"
       
    private Piece[] gameBoard;
    private Move[] MovesHistory;
    private int moveCounter;
    protected override async Task OnInitializedAsync()
    {
        gameBoard = await GameStateService.GetPieceData();
        moveCounter = 0;
        Move[] moves = new Move[]
        {
            new Move(2 ,48, 40),
            new Move(2, 49, 41),
            new Move(4, 50, 42),
            new Move(5, 40, 32)
        };
        MovesHistory = moves;
    }


    public void moveForward()
    {
        Move currentMove = MovesHistory[moveCounter];
        this.gameBoard[currentMove.toField] = this.gameBoard[currentMove.fromField];
        this.gameBoard[currentMove.fromField] = getClearField();
        if (moveCounter < MovesHistory.Length - 1) moveCounter++;
    }
    public void moveBackwards()
    {
        if (moveCounter > 0) moveCounter--;
    }

    public void moveFastForward()
    {
        moveCounter = MovesHistory.Length;
    }

    public void moveFastBackwards()
    {
        moveCounter = 0;
    }

    public Piece getClearField()
    {
        return new Piece(0, false);
    }

    public string getMoveInNotation(Move move)
    {
        string fieldName = "";
        fieldName += getPieceName(move.pieceId);
        fieldName += ((char) (move.toField % 8 + 97));
        fieldName += (8 - move.toField / 8).ToString();
        return fieldName;
    }

    public string getPieceName(int pieceId)
    {
        switch (pieceId)
        {
            case 0:
                return "";
            case 1:
                return ""; // pawn
            case 2:
                return "R"; // rook
            case 3:
                return "N"; // knight
            case 4:
                return "B"; // bishop
            case 5:
                return "Q"; // queen
            case 6:
                return "K"; // king
        }
        return "";
    }

    public string GetPiece(Piece piece)
    {
        if (piece.Color)
        {
            switch (piece.Id)
            {
                case 1:
                    return "♙";
                case 2:
                    return "♖";
                case 3:
                    return "♘";
                case 4:
                    return "♗";
                case 5:
                    return "♕";
                case 6:
                    return "♔";
                default:
                    return "";
            }
        }
        else
        {
            switch (piece.Id)
            {
                case 1:
                    return "♟";
                case 2:
                    return "♜";
                case 3:
                    return "♞";
                case 4:
                    return "♝";
                case 5:
                    return "♛";
                case 6:
                    return "♚";
                default:
                    return "";
            }
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ChessGameStateService GameStateService { get; set; }
    }
}
#pragma warning restore 1591
