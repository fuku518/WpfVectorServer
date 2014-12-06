﻿using Microsoft.AspNet.SignalR;

namespace WpfVectorServer
{
    public class MyHub : Hub
    {
        private const string Original = @"[{""X1"":427,""X2"":410,""Y1"":70,""Y2"":113},{""X1"":410,""X2"":399,""Y1"":113,""Y2"":149},{""X1"":399,""X2"":390,""Y1"":149,""Y2"":216},{""X1"":390,""X2"":383,""Y1"":216,""Y2"":289},{""X1"":383,""X2"":383,""Y1"":289,""Y2"":350},{""X1"":383,""X2"":390,""Y1"":350,""Y2"":401},{""X1"":390,""X2"":409,""Y1"":401,""Y2"":459},{""X1"":409,""X2"":434,""Y1"":459,""Y2"":492},{""X1"":434,""X2"":463,""Y1"":492,""Y2"":512},{""X1"":463,""X2"":505,""Y1"":512,""Y2"":527},{""X1"":505,""X2"":554,""Y1"":527,""Y2"":531},{""X1"":554,""X2"":589,""Y1"":531,""Y2"":526},{""X1"":589,""X2"":622,""Y1"":526,""Y2"":514},{""X1"":622,""X2"":656,""Y1"":514,""Y2"":493},{""X1"":656,""X2"":686,""Y1"":493,""Y2"":467},{""X1"":686,""X2"":711,""Y1"":467,""Y2"":426},{""X1"":445,""X2"":459,""Y1"":132,""Y2"":109},{""X1"":459,""X2"":473,""Y1"":109,""Y2"":102},{""X1"":473,""X2"":490,""Y1"":102,""Y2"":109},{""X1"":490,""X2"":535,""Y1"":109,""Y2"":138},{""X1"":580,""X2"":598,""Y1"":143,""Y2"":119},{""X1"":598,""X2"":614,""Y1"":119,""Y2"":114},{""X1"":614,""X2"":689,""Y1"":114,""Y2"":150},{""X1"":486,""X2"":486,""Y1"":196,""Y2"":222},{""X1"":486,""X2"":476,""Y1"":222,""Y2"":236},{""X1"":476,""X2"":461,""Y1"":236,""Y2"":244},{""X1"":461,""X2"":443,""Y1"":244,""Y2"":234},{""X1"":443,""X2"":447,""Y1"":234,""Y2"":214},{""X1"":447,""X2"":465,""Y1"":214,""Y2"":199},{""X1"":465,""X2"":486,""Y1"":199,""Y2"":198},{""X1"":486,""X2"":505,""Y1"":198,""Y2"":205},{""X1"":505,""X2"":515,""Y1"":205,""Y2"":226},{""X1"":515,""X2"":513,""Y1"":226,""Y2"":240},{""X1"":513,""X2"":505,""Y1"":240,""Y2"":255},{""X1"":629,""X2"":629,""Y1"":191,""Y2"":224},{""X1"":629,""X2"":619,""Y1"":224,""Y2"":241},{""X1"":619,""X2"":600,""Y1"":241,""Y2"":247},{""X1"":600,""X2"":590,""Y1"":247,""Y2"":233},{""X1"":590,""X2"":592,""Y1"":233,""Y2"":216},{""X1"":592,""X2"":611,""Y1"":216,""Y2"":198},{""X1"":611,""X2"":633,""Y1"":198,""Y2"":194},{""X1"":633,""X2"":664,""Y1"":194,""Y2"":211},{""X1"":664,""X2"":670,""Y1"":211,""Y2"":239},{""X1"":670,""X2"":661,""Y1"":239,""Y2"":253},{""X1"":549,""X2"":535,""Y1"":256,""Y2"":302},{""X1"":535,""X2"":532,""Y1"":302,""Y2"":337},{""X1"":532,""X2"":536,""Y1"":337,""Y2"":349},{""X1"":536,""X2"":546,""Y1"":349,""Y2"":364},{""X1"":546,""X2"":570,""Y1"":364,""Y2"":352},{""X1"":570,""X2"":579,""Y1"":352,""Y2"":345},{""X1"":579,""X2"":579,""Y1"":345,""Y2"":335},{""X1"":515,""X2"":560,""Y1"":289,""Y2"":285},{""X1"":509,""X2"":562,""Y1"":322,""Y2"":316},{""X1"":497,""X2"":529,""Y1"":427,""Y2"":397},{""X1"":529,""X2"":536,""Y1"":397,""Y2"":392},{""X1"":536,""X2"":544,""Y1"":392,""Y2"":392},{""X1"":544,""X2"":615,""Y1"":392,""Y2"":430},{""X1"":615,""X2"":641,""Y1"":430,""Y2"":434},{""X1"":721,""X2"":743,""Y1"":123,""Y2"":181},{""X1"":747,""X2"":772,""Y1"":114,""Y2"":176}]";

        public void LoadInServer()
        {
            Clients.All.loadInClient(Original);
        }
    }
}