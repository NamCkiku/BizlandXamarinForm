using System;
using System.Collections.Generic;
using System.Text;

namespace Bizland.Core.Constant
{
    /// <summary>
    /// Thông tin cấu hình
    /// </summary>
    public class Config
    {
        public const string ApiEndpoint = "http://api.bizland.vn";

        public const string UserNameApi = "BinhAnh";

        public const string PasswordApi = "binhanh@123";

        /// <summary>
        /// true => debug mode, đẩy bản thật thì set về false
        /// </summary>
        public const bool IS_DEBUG_MODE = true;

        /// <summary>
        /// Tọa độ Bình Anh: Số 30 61, Ngõ 88 Giáp Nhị, Giáp Nhị, Thịnh Liệt.
        /// </summary>
        public const double DEFAULT_LATITUDE = 20.973993f;

        /// <summary>
        /// Tọa độ Bình Anh: Số 30 61, Ngõ 88 Giáp Nhị, Giáp Nhị, Thịnh Liệt.
        /// </summary>
        public const double DEFAULT_LONGITUDE = 105.846421f;
    }
}
