namespace Ealse.TPLink.Api.Models.Enums
{
	public enum ErrorCode : int
	{
		TokenExpired = -20_651,
		PasswordOrEmailIncorrect = -20_601,
		DeviceIsOffline = -20_571,
		AccountLoginInOtherPlaces = -20_675,
		EmailFormatError = -20_200,
		MethodDoesNotExist = -20_103,
		Timeout = -20_002,
		JsonFormatError = -10_100,
		RequestMethodGetNotSupported = -10_000,
		None = 0,
	}
}
