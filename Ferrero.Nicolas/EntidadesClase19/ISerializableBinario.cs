﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesClase19
{
    public interface ISerializableBinario
    {
        void Serializar();

        Jugador Deserializar();
    }
}
