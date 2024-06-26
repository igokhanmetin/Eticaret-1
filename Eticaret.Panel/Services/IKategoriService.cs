﻿using Eticaret.Model;

namespace Eticaret.Panel.Services
{
    public interface IKategoriService : IBaseInterface<Kategori>
    {
        public Task<bool> AktiflestirAsync(Guid id);

        public Task<bool> PasiflestirAsync(Guid id);

    }
}
