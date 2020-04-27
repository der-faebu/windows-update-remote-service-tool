﻿/*
    Windows Update Remote Service
    Copyright(C) 2016-2020  Elia Seikritt

    This program is free software: you can redistribute it and/or modify
    it under the terms of the GNU Lesser General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.See the
    GNU General Public License for more details.

    You should have received a copy of the GNU Lesser General Public License
    along with this program.If not, see<https://www.gnu.org/licenses/>.
*/
namespace WuDataContract.Enums
{
    /// <summary>
    /// Default timeouts for async operations to avoid infinitely running tasks. All values in seconds.
    /// </summary>
    public enum DefaultAsyncOperationTimeout
    {
        SearchTimeout = 1200,
        DownloadTimeout = 7200,
        InstallTimeout = 10800
    }
}
