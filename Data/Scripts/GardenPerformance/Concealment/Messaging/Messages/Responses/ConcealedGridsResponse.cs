﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using SEGarden.Extensions;

using GP.Concealment.Records.Entities;

namespace GP.Concealment.Messaging.Messages.Responses {

    class ConcealedGridsResponse : Response {

        public static ConcealedGridsResponse FromBytes(byte[] bytes) {
            VRage.ByteStream stream = new VRage.ByteStream(bytes, bytes.Length);
            ConcealedGridsResponse response = new ConcealedGridsResponse();

            ConcealableGrid grid;
            ushort count = stream.getUShort();
            for (int i = 0; i < count; i++) {
                grid = new ConcealableGrid();
                grid.RemoveFromByteStream(stream);
                response.ConcealedGrids.Add(grid);
            }

            return response;
        }

        public List<ConcealableGrid> ConcealedGrids = new List<ConcealableGrid>();

        public ConcealedGridsResponse() :
            base((ushort)MessageType.ConcealedGridsResponse) { }

        protected override byte[] ToBytes() {
            VRage.ByteStream stream = new VRage.ByteStream(32, true);

            stream.addUShort((ushort)ConcealedGrids.Count);
            foreach (ConcealableGrid grid in ConcealedGrids) {
                grid.AddToByteStream(stream);
            }

            return stream.Data;
        }

    }
}
