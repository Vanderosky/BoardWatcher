#pragma checksum "C:\Users\Vander\Documents\Programming\C#\BoardWatcher\Pages\Chess.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d0a7a5169b002d779b0e8d547809e3d8da603eb9"
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
        public Piece(int id, Boolean colour, Coords coord)
        {
            this.Id = id;
            this.Colour = colour;
            this.Coord = coord;
        }
        private int Id { get; set; }
        private Boolean Colour { get; set; }
        private Coords Coord { get; set; }

    }

    public struct Coords
    {
        public Coords(double x, double y)
        {
            X = x;
            Y = y;
        }

        public double X { get; }
        public double Y { get; }

        public override string ToString() => $"({X}, {Y})";
    }
    public class GameState
    {
        public string Event { get; set; }
        public string Site { get; set; }
        public string Date { get; set; }
        public string Round { get; set; }
        public string White { get; set; }
        public string Black { get; set; }
        public string Result { get; set; }
        public Move[] Moves { get; set; }
        public Piece[] GamePieces = new Piece[32];

        public void generateNewGamePieces()
        {
            Piece[] newPieces = new Piece[] 
            {
                // first black row
                new Piece(0, false, new Coords(8, 1)),
                new Piece(1, false, new Coords(8, 2)),
                new Piece(2, false, new Coords(8, 3)),
                new Piece(3, false, new Coords(8, 4)),
                new Piece(4, false, new Coords(8, 5)),
                new Piece(2, false, new Coords(8, 6)),
                new Piece(1, false, new Coords(8, 7)),
                new Piece(0, false, new Coords(8, 8)),
                // second black row (pawns)
                new Piece(5, false, new Coords(7, 1)),
                new Piece(5, false, new Coords(7, 2)),
                new Piece(5, false, new Coords(7, 3)),
                new Piece(5, false, new Coords(7, 4)),
                new Piece(5, false, new Coords(7, 5)),
                new Piece(5, false, new Coords(7, 6)),
                new Piece(5, false, new Coords(7, 7)),
                new Piece(5, false, new Coords(7, 8)),
                // first white row (pawns)
                new Piece(5, true, new Coords(2, 1)),
                new Piece(5, true, new Coords(2, 2)),
                new Piece(5, true, new Coords(2, 3)),
                new Piece(5, true, new Coords(2, 4)),
                new Piece(5, true, new Coords(2, 5)),
                new Piece(5, true, new Coords(2, 6)),
                new Piece(5, true, new Coords(2, 7)),
                new Piece(5, true, new Coords(2, 8)),
                // second white row
                new Piece(0, true, new Coords(1, 1)),
                new Piece(1, true, new Coords(1, 2)),
                new Piece(2, true, new Coords(1, 3)),
                new Piece(3, true, new Coords(1, 4)),
                new Piece(4, true, new Coords(1, 5)),
                new Piece(2, true, new Coords(1, 6)),
                new Piece(1, true, new Coords(1, 7)),
                new Piece(0, true, new Coords(1, 8)),
            };
        }

        public void GameStateParser(string input)
        {
            //TODO
        }
    }

    public struct Move
    {
        public int MoveId { get; }
        public int Piece { get; }
        public int CordX { get; }
        public int CordY { get; }

        //TO FINISH WITH GameStateParser
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
