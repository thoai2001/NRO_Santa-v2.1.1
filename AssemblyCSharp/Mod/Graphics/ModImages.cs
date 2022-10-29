﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mod.Graphics
{
    public class ModImages
    {
        public static Image infinitySymbol;

        static ModImages()
        {
            if (mGraphics.zoomLevel == 2) infinitySymbol = Image.createImage(Convert.FromBase64String("iVBORw0KGgoAAAANSUhEUgAAABYAAAAOCAYAAAArMezNAAAABmJLR0QAAAAAAAD5Q7t/AAAACXBIWXMAAC4jAAAuIwF4pT92AAAAB3RJTUUH5ggYBRs6wOW2TQAAABl0RVh0Q29tbWVudABDcmVhdGVkIHdpdGggR0lNUFeBDhcAAAKuSURBVDjLhZJZSNRRFMa/+/9bqeWS4iguYESrlUGQ5ku9RW9BKUTEZPjSQ9D2oGAbClImhVAPpWaRQ5n4IEUYgeFSaq6zuO86MjAuM6OzkDPz9dD8h2mY7Hu695zf/c49517AJ5JRJEtIjpB0kVwgqSF5BAEiqSJZRnKUpJOkiWQtyVQEi2Q8SR1Dy0XyvI/bR3LxH9wiyfRg4zpuLqfPVP8frjnQNJmkW8no+nt596qaRVfy2N3RFnjIrCyWzWY+vV/E63mn+a35c7D5XgAQJC8A0ACAzWrFzbNZcLss/sLXnjTiWHaOf+/1elFRfBuGFo0/VtGkRXyCStkWCCGqJfv6eoYSWZyfg9tlqaJwp3olJJIs7/jy6a+xGQb7YWjR6GUvj7q5EUOIQpPR6M/brJbDAIDZqcl3Sg/Deq0tNxdyoNH8zLQ2sM/KkuKNyyeS9wcyk6MjK0p+anysAQDQ1/WjXgnarJaVoEfNCJw/SY4NGQaCGNlht1uVfFd76wcAkAa6OuYUKCo6ZifJQpLRJDMBNAB/OnA5nQCAPQcOZpIsJZlAMhnAs4jIyGhfEfS2t0wAANRZSflz01Ob/qHlJTMfFd2g272xKTc2pKc6W3URACSP5Gl7U/kQDocdoeRw2FH1uBSGFs1S49vX8Hg8IbnVlWXUlD/wSp6wVgCQtQuOlTSxkGPQje9WpaVjR1Q0JEnCms0KXV8vXpbdwdTPjwYh5DNjPV8L5oyrYXGqJIRHREKWZazZbND2dOP5vVtYmuisr+021QCAAIBLxxN3SRK+A0gKcRmTLMunajoWR9VZqnMQog7AthDcsLRFnHzVZjJDeRit0W45lBL7XhKeOEAkAwgDME2yZiugrv5hmgWAQaN9ODNle5OAiIVAnK/ADAVehG/8yq/uXPL/qt9/H3/adH6lhwAAAABJRU5ErkJggg=="));
            if (mGraphics.zoomLevel == 1) infinitySymbol = Image.createImage(Convert.FromBase64String("iVBORw0KGgoAAAANSUhEUgAAAA4AAAAICAYAAADJEc7MAAAABmJLR0QAAAAAAAD5Q7t/AAAACXBIWXMAAC4jAAAuIwF4pT92AAAAB3RJTUUH5ggYBgEWQFaeLAAAABl0RVh0Q29tbWVudABDcmVhdGVkIHdpdGggR0lNUFeBDhcAAADDSURBVBjTpdAxK8ZxFMXx85OFIjFJicUbUMoib4DF27CYbF6BUgaL1aAMNovFaGCmTBZSz+BRzyL6GNx//rvvdO+599xON0mCDdxhhFuslb6LZ7zjDFPpwHwZbjCHAwyxjy9sYh3fOO0b9/yyU33DQ2mXvb17jLp+LMli1S9J0lpTepKc549BkklMd8bXGszW5dUkK6V99YwLSYattY8uwjI+cYEZXFXUYzzVfLuiH6UPtvBYT7rGEsZxiAHecIKJ/Jcfl2HO8PpZsMkAAAAASUVORK5CYII="));
        }
    }
}
