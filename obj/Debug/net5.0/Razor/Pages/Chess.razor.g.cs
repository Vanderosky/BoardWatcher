#pragma checksum "C:\Users\Vander\Documents\Programming\C#\BoardWatcher\Pages\Chess.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "102479b4d3195aa0a96c26b35946e23e01e58f23"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/chess")]
    public partial class Chess : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<table class=\"chess-board\" b-n0nxo8uhw8><tbody b-n0nxo8uhw8><tr b-n0nxo8uhw8><th b-n0nxo8uhw8></th>\r\n            <th b-n0nxo8uhw8>a</th>\r\n            <th b-n0nxo8uhw8>b</th>\r\n            <th b-n0nxo8uhw8>c</th>\r\n            <th b-n0nxo8uhw8>d</th>\r\n            <th b-n0nxo8uhw8>e</th>\r\n            <th b-n0nxo8uhw8>f</th>\r\n            <th b-n0nxo8uhw8>g</th>\r\n            <th b-n0nxo8uhw8>h</th></tr>\r\n\r\n        <tr b-n0nxo8uhw8><th b-n0nxo8uhw8>8</th>\r\n            <td class=\"light\" b-n0nxo8uhw8>♜</td>\r\n            <td class=\"dark\" b-n0nxo8uhw8>♞</td>\r\n            <td class=\"light\" b-n0nxo8uhw8>♝</td>\r\n            <td class=\"dark\" b-n0nxo8uhw8>♛</td>\r\n            <td class=\"light\" b-n0nxo8uhw8>♚</td>\r\n            <td class=\"dark\" b-n0nxo8uhw8>♝</td>\r\n            <td class=\"light\" b-n0nxo8uhw8>♞</td>\r\n            <td class=\"dark\" b-n0nxo8uhw8>♜</td></tr>\r\n        <tr b-n0nxo8uhw8><th b-n0nxo8uhw8>7</th>\r\n            <td class=\"dark\" b-n0nxo8uhw8>♟</td>\r\n            <td class=\"light\" b-n0nxo8uhw8>♟</td>\r\n            <td class=\"dark\" b-n0nxo8uhw8>♟</td>\r\n            <td class=\"light\" b-n0nxo8uhw8>♟</td>\r\n            <td class=\"dark\" b-n0nxo8uhw8>♟</td>\r\n            <td class=\"light\" b-n0nxo8uhw8>♟</td>\r\n            <td class=\"dark\" b-n0nxo8uhw8>♟</td>\r\n            <td class=\"light\" b-n0nxo8uhw8>♟</td></tr>\r\n        <tr b-n0nxo8uhw8><th b-n0nxo8uhw8>6</th>\r\n            <td class=\"light\" b-n0nxo8uhw8></td>\r\n            <td class=\"dark\" b-n0nxo8uhw8></td>\r\n            <td class=\"light\" b-n0nxo8uhw8></td>\r\n            <td class=\"dark\" b-n0nxo8uhw8></td>\r\n            <td class=\"light\" b-n0nxo8uhw8></td>\r\n            <td class=\"dark\" b-n0nxo8uhw8></td>\r\n            <td class=\"light\" b-n0nxo8uhw8></td>\r\n            <td class=\"dark\" b-n0nxo8uhw8></td></tr>\r\n        <tr b-n0nxo8uhw8><th b-n0nxo8uhw8>5</th>\r\n            <td class=\"dark\" b-n0nxo8uhw8></td>\r\n            <td class=\"light\" b-n0nxo8uhw8></td>\r\n            <td class=\"dark\" b-n0nxo8uhw8></td>\r\n            <td class=\"light\" b-n0nxo8uhw8></td>\r\n            <td class=\"dark\" b-n0nxo8uhw8></td>\r\n            <td class=\"light\" b-n0nxo8uhw8></td>\r\n            <td class=\"dark\" b-n0nxo8uhw8></td>\r\n            <td class=\"light\" b-n0nxo8uhw8></td></tr>\r\n        <tr b-n0nxo8uhw8><th b-n0nxo8uhw8>4</th>\r\n            <td class=\"light\" b-n0nxo8uhw8></td>\r\n            <td class=\"dark\" b-n0nxo8uhw8></td>\r\n            <td class=\"light\" b-n0nxo8uhw8></td>\r\n            <td class=\"dark\" b-n0nxo8uhw8></td>\r\n            <td class=\"light\" b-n0nxo8uhw8></td>\r\n            <td class=\"dark\" b-n0nxo8uhw8></td>\r\n            <td class=\"light\" b-n0nxo8uhw8></td>\r\n            <td class=\"dark\" b-n0nxo8uhw8></td></tr>\r\n        <tr b-n0nxo8uhw8><th b-n0nxo8uhw8>3</th>\r\n            <td class=\"dark\" b-n0nxo8uhw8></td>\r\n            <td class=\"light\" b-n0nxo8uhw8></td>\r\n            <td class=\"dark\" b-n0nxo8uhw8></td>\r\n            <td class=\"light\" b-n0nxo8uhw8></td>\r\n            <td class=\"dark\" b-n0nxo8uhw8></td>\r\n            <td class=\"light\" b-n0nxo8uhw8></td>\r\n            <td class=\"dark\" b-n0nxo8uhw8></td>\r\n            <td class=\"light\" b-n0nxo8uhw8></td></tr>\r\n        <tr b-n0nxo8uhw8><th b-n0nxo8uhw8>2</th>\r\n            <td class=\"light\" b-n0nxo8uhw8>♙</td>\r\n            <td class=\"dark\" b-n0nxo8uhw8>♙</td>\r\n            <td class=\"light\" b-n0nxo8uhw8>♙</td>\r\n            <td class=\"dark\" b-n0nxo8uhw8>♙</td>\r\n            <td class=\"light\" b-n0nxo8uhw8>♙</td>\r\n            <td class=\"dark\" b-n0nxo8uhw8>♙</td>\r\n            <td class=\"light\" b-n0nxo8uhw8>♙</td>\r\n            <td class=\"dark\" b-n0nxo8uhw8>♙</td></tr>\r\n        <tr b-n0nxo8uhw8><th b-n0nxo8uhw8>1</th>\r\n            <td class=\"dark\" b-n0nxo8uhw8>♖</td>\r\n            <td class=\"light\" b-n0nxo8uhw8>♘</td>\r\n            <td class=\"dark\" b-n0nxo8uhw8>♗</td>\r\n            <td class=\"light\" b-n0nxo8uhw8>♕</td>\r\n            <td class=\"dark\" b-n0nxo8uhw8>♔</td>\r\n            <td class=\"light\" b-n0nxo8uhw8>♗</td>\r\n            <td class=\"dark\" b-n0nxo8uhw8>♘</td>\r\n            <td class=\"light\" b-n0nxo8uhw8>♖</td></tr></tbody></table>\r\n");
            __builder.AddMarkupContent(1, @"<div class=""stateMenu"" b-n0nxo8uhw8><button class=""btn btn-primary"" b-n0nxo8uhw8><span class=""oi oi-media-skip-backward"" aria-hidden=""true"" b-n0nxo8uhw8></span></button>
    <button class=""btn btn-primary"" b-n0nxo8uhw8><span class=""oi oi-media-step-backward"" aria-hidden=""true"" b-n0nxo8uhw8></span></button>
    <button class=""btn btn-primary"" b-n0nxo8uhw8><span class=""oi oi-media-step-forward"" aria-hidden=""true"" b-n0nxo8uhw8></span></button>
    <button class=""btn btn-primary"" b-n0nxo8uhw8><span class=""oi oi-media-skip-forward"" aria-hidden=""true"" b-n0nxo8uhw8></span></button></div>");
        }
        #pragma warning restore 1998
#nullable restore
#line 142 "C:\Users\Vander\Documents\Programming\C#\BoardWatcher\Pages\Chess.razor"
       
    public class Piece
    {
        public Piece(int id, Boolean colour)
        {
            this.Id = id;
            this.Colour = colour;
        }
        private int id;
        public int Id 
        { 
            get { return Id; }
            set { Id = value; }
        }
        private Boolean colour;
        public Boolean Colour
        { 
            get { return Colour; }
            set { Colour = value; }
        }

    }

    public class GameState
    {
        private string Event { get; set; }
        private string Site { get; set; }
        private string Date { get; set; }
        private string Round { get; set; }
        private string White { get; set; }
        private string Black { get; set; }
        private string Result { get; set; }
        private Piece[] board;

        private Piece[] Board
        { 
            get { return Board; }
            set { Board = value; }
        }
        public void generateNewBoard()
        {
            Piece[] pieces = new Piece[64];
            Piece[] blackPieces = new Piece[]
            {
                new Piece(2, false),
                new Piece(3, false),
                new Piece(4, false),
                new Piece(5, false),
                new Piece(6, false),
                new Piece(4, false),
                new Piece(3, false),
                new Piece(2, false),

                new Piece(1, false),
                new Piece(1, false),
                new Piece(1, false),
                new Piece(1, false),
                new Piece(1, false),
                new Piece(1, false),
                new Piece(1, false),
                new Piece(1, false)
            };
            Piece[] whitePieces = new Piece[]
            {
                new Piece(1, true),
                new Piece(1, true),
                new Piece(1, true),
                new Piece(1, true),
                new Piece(1, true),
                new Piece(1, true),
                new Piece(1, true),
                new Piece(1, true),

                new Piece(2, true),
                new Piece(3, true),
                new Piece(4, true),
                new Piece(5, true),
                new Piece(6, true),
                new Piece(4, true),
                new Piece(3, true),
                new Piece(2, true)
            };
            pieces.Concat(blackPieces).ToArray();
            for(int i = 0; i < 32; i++)
            {
                pieces.Append(new Piece(0, false));
            }
            pieces.Concat(whitePieces).ToArray();
        }

        public string GetPiece(int tileId)
        {
            Piece tmpPiece = this.Board[tileId];
            if (tmpPiece.Colour)
            {
                switch (tmpPiece.Id)
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
            } else
            {
                switch (tmpPiece.Id)
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
        }

        public void GameStateParser(string input)
        {
            //TODO
        }
    }
    private GameState gameState = new GameState();
    protected override void OnInitialized()
    {
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
