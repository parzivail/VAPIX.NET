namespace VAPIX.NET
{
	public class PtzCommandBuilder : CommandBuilder
	{
		public PtzCommandBuilder() : base("axis-cgi/com/ptz.cgi")
		{
		}

		/// <summary>
		/// Selects the video channel. If omitted the default value camera=1 is used. This argument is only valid for Axis products with more than one video channel. That is cameras with multiple view areas and video encoders with multiple video channels.
		/// </summary>
		/// <param name="camera"></param>
		/// <returns></returns>
		public PtzCommandBuilder Camera(int camera)
		{
			WithParameter(new IntRequestParameter("camera", camera));
			return this;
		}

		/// <summary>
		/// Center the camera on positions x,y where x,y are pixel coordinates in the client video stream.
		/// </summary>
		/// <param name="x"></param>
		/// <param name="y"></param>
		/// <returns></returns>
		public PtzCommandBuilder Center(int x, int y)
		{
			WithParameter(new Point2RequestParameter("center", x, y));
			return this;
		}

		/// <summary>
		/// Centers on positions x,y (like the center command) and zooms by a factor of z/100. If z is more than 100 the image is zoomed in (for example; z=300 zooms in to 1/3 of the current field of view). If z is less than 100 the image is zoomed out (for example; z=50 zooms out to twice the current field of view).
		/// </summary>
		/// <remarks>In some Axis products, the precision of areazoom can be strongly improved by calibrating the lens offset parameters.</remarks>
		/// <param name="x"></param>
		/// <param name="y"></param>
		/// <param name="z"></param>
		/// <returns></returns>
		public PtzCommandBuilder AreaZoom(int x, int y, int z)
		{
			WithParameter(new Point3RequestParameter("areazoom", x, y, z));
			return this;
		}

		/// <summary>
		/// Required in conjunction with center or areazoom if the image width displayed is different from the default size of the image, which is product-specific.
		/// </summary>
		/// <param name="width"></param>
		/// <returns></returns>
		public PtzCommandBuilder ImageWidth(int width)
		{
			WithParameter(new IntRequestParameter("imagewidth", width));
			return this;
		}

		/// <summary>
		/// Required in conjunction with center or areazoom if the image height is different from the default size of the image, which is product-specific.
		/// </summary>
		/// <param name="height"></param>
		/// <returns></returns>
		public PtzCommandBuilder ImageHeight(int height)
		{
			WithParameter(new IntRequestParameter("imageheight", height));
			return this;
		}

		/// <summary>
		/// Absolute: Moves the image 25 % of the image field width in the specified direction.
		/// Relative: Moves the device approx. 50-90 degrees(2) in the specified direction.
		/// </summary>
		/// <param name="direction"></param>
		/// <returns></returns>
		public PtzCommandBuilder Move(MoveDirection direction)
		{
			WithParameter(new MoveRequestParameter("move", direction));
			return this;
		}

		/// <summary>
		/// Pans the device to the specified absolute coordinates.
		/// </summary>
		/// <param name="angle"></param>
		/// <returns></returns>
		public PtzCommandBuilder Pan(float angle)
		{
			WithParameter(new FloatRequestParameter("pan", angle));
			return this;
		}

		/// <summary>
		/// Tilts the device to the specified absolute coordinates.
		/// </summary>
		/// <param name="angle"></param>
		/// <returns></returns>
		public PtzCommandBuilder Tilt(float angle)
		{
			WithParameter(new FloatRequestParameter("tilt", angle));
			return this;
		}

		/// <summary>
		/// Zooms the device n steps to the specified absolute position. A high value means zoom in, a low value means zoom out.
		/// </summary>
		/// <param name="zoom"></param>
		/// <returns></returns>
		public PtzCommandBuilder Zoom(int zoom)
		{
			WithParameter(new IntRequestParameter("zoom", zoom));
			return this;
		}
		
		/// <summary>
		/// Moves focus n steps to the specified absolute position. A high value means focus far, a low value means focus near.
		/// </summary>
		/// <param name="focus"></param>
		/// <returns></returns>
		public PtzCommandBuilder Focus(int focus)
		{
			WithParameter(new IntRequestParameter("focus", focus));
			return this;
		}
		
		/// <summary>
		/// Moves iris n steps to the specified absolute position. A high value means open iris, a low value means close iris.
		/// </summary>
		/// <param name="iris"></param>
		/// <returns></returns>
		public PtzCommandBuilder Iris(int iris)
		{
			WithParameter(new IntRequestParameter("iris", iris));
			return this;
		}
		
		/// <summary>
		/// Moves brightness n steps to the specified absolute position. A high value means brighter image, a low value means darker image.
		/// </summary>
		/// <param name="brightness"></param>
		/// <returns></returns>
		public PtzCommandBuilder Brightness(int brightness)
		{
			WithParameter(new IntRequestParameter("brightness", brightness));
			return this;
		}
		
		/// <summary>
		/// Pans the device n degrees relative to the current position.
		/// </summary>
		/// <param name="angle"></param>
		/// <returns></returns>
		public PtzCommandBuilder RPan(float angle)
		{
			WithParameter(new FloatRequestParameter("rpan", angle));
			return this;
		}
		
		/// <summary>
		/// Tilts the device n degrees relative to the current position.
		/// </summary>
		/// <param name="angle"></param>
		/// <returns></returns>
		public PtzCommandBuilder RTilt(float angle)
		{
			WithParameter(new FloatRequestParameter("rtilt", angle));
			return this;
		}
		
		/// <summary>
		/// Zooms the device n steps relative to the current position. Positive values mean zoom in, negative values mean zoom out.
		/// </summary>
		/// <param name="zoom"></param>
		/// <returns></returns>
		public PtzCommandBuilder RZoom(int zoom)
		{
			WithParameter(new IntRequestParameter("rzoom", zoom));
			return this;
		}
		
		/// <summary>
		/// Moves focus n steps relative to the current position. Positive values mean focus far, negative values mean focus near.
		/// </summary>
		/// <param name="focus"></param>
		/// <returns></returns>
		public PtzCommandBuilder RFocus(int focus)
		{
			WithParameter(new IntRequestParameter("rfocus", focus));
			return this;
		}
		
		/// <summary>
		/// Moves iris n steps relative to the current position. Positive values mean open iris, negative values mean close iris.
		/// </summary>
		/// <param name="iris"></param>
		/// <returns></returns>
		public PtzCommandBuilder RIris(int iris)
		{
			WithParameter(new IntRequestParameter("riris", iris));
			return this;
		}
		
		/// <summary>
		/// Moves brightness n steps relative to the current position. Positive values mean brighter image, negative values mean darker image.
		/// </summary>
		/// <param name="brightness"></param>
		/// <returns></returns>
		public PtzCommandBuilder RBrightness(int brightness)
		{
			WithParameter(new IntRequestParameter("rbrightness", brightness));
			return this;
		}
		
		/// <summary>
		/// Enable/disable auto focus.
		/// </summary>
		/// <param name="enabled"></param>
		/// <returns></returns>
		public PtzCommandBuilder AutoFocus(bool enabled)
		{
			WithParameter(new OnOffRequestParameter("autofocus", enabled));
			return this;
		}
		
		/// <summary>
		/// Enable/disable auto iris.
		/// </summary>
		/// <param name="enabled"></param>
		/// <returns></returns>
		public PtzCommandBuilder AutoIris(bool enabled)
		{
			WithParameter(new OnOffRequestParameter("autoiris", enabled));
			return this;
		}
		
		/// <summary>
		/// Continuous pan/tilt motion. Positive values mean right (pan) and up (tilt), negative values mean left (pan) and down (tilt). 0,0 means stop.
		/// </summary>
		/// <param name="pan"></param>
		/// <param name="tilt"></param>
		/// <param name="proportionalSpeed"></param>
		/// <returns></returns>
		public PtzCommandBuilder ContinuousPanTiltMove(int pan, int tilt, bool proportionalSpeed = true)
		{
			WithParameter(new Point2RequestParameter("continuouspantiltmove", pan, tilt));
			if (!proportionalSpeed)
				WithParameter(new StringRequestParameter("proportionalspeed", "disabled"));
			return this;
		}
		
		/// <summary>
		/// Continuous zoom motion. Positive values mean zoom in and negative values mean zoom out. 0 means stop.
		/// </summary>
		/// <param name="zoom"></param>
		/// <returns></returns>
		public PtzCommandBuilder ContinuousZoomMove(int zoom)
		{
			WithParameter(new IntRequestParameter("continuouszoommove", zoom));
			return this;
		}
		
		/// <summary>
		/// Continuous focus motion. Positive values mean focus far and negative values mean focus near. 0 means stop.
		/// </summary>
		/// <param name="focus"></param>
		/// <returns></returns>
		public PtzCommandBuilder ContinuousFocusMove(int focus)
		{
			WithParameter(new IntRequestParameter("continuousfocusmove", focus));
			return this;
		}
		
		/// <summary>
		/// Continuous iris motion. Positive values mean iris open and negative values mean iris close. 0 means stop.
		/// </summary>
		/// <param name="iris"></param>
		/// <returns></returns>
		public PtzCommandBuilder ContinuousIrisMove(int iris)
		{
			WithParameter(new IntRequestParameter("continuousirismove", iris));
			return this;
		}
		
		/// <summary>
		/// Continuous brightness motion. Positive values mean brighter image and negative values mean darker image. 0 means stop.
		/// </summary>
		/// <param name="brightness"></param>
		/// <returns></returns>
		public PtzCommandBuilder ContinuousBrightnessMove(int brightness)
		{
			WithParameter(new IntRequestParameter("continuousbrightnessmove", brightness));
			return this;
		}
		
		/// <summary>
		/// Move to the position associated with the preset name.
		/// </summary>
		/// <param name="name"></param>
		/// <returns></returns>
		public PtzCommandBuilder GoToServerPresetName(string name)
		{
			WithParameter(new StringRequestParameter("gotoserverpresetname", name));
			return this;
		}
		
		/// <summary>
		/// Move to the position associated with the specified preset position number.
		/// </summary>
		/// <param name="index"></param>
		/// <returns></returns>
		public PtzCommandBuilder GoToServerPresetNo(int index)
		{
			WithParameter(new IntRequestParameter("gotoserverpresetno", index));
			return this;
		}
		
		/// <summary>
		/// Bypasses the presetpos interface and tells the device to go directly to the preset position number stored in the device, where the preset pos is a device-specific preset position number. This may also be a device-specific special function.
		/// </summary>
		/// <param name="pos"></param>
		/// <returns></returns>
		public PtzCommandBuilder GoToServerPreset(int pos)
		{
			WithParameter(new IntRequestParameter("gotodevicepreset", pos));
			return this;
		}
		
		/// <summary>
		/// Sets the move speed of pan and tilt.
		/// </summary>
		/// <param name="speed"></param>
		/// <returns></returns>
		public PtzCommandBuilder Speed(int speed)
		{
			WithParameter(new IntRequestParameter("speed", speed));
			return this;
		}
		
		/// <summary>
		/// If PTZ command refers to an image stream that is rotated differently than the current image setup, then the image stream rotation must be added to each command with this argument to allow the Axis product to compensate.
		/// </summary>
		/// <param name="rotation"></param>
		/// <returns></returns>
		public PtzCommandBuilder ImageRotation(ImageRotation rotation)
		{
			WithParameter(new IntRequestParameter("imagerotation", (int)rotation));
			return this;
		}
		
		/// <summary>
		/// Control the IR cut filter.
		/// </summary>
		/// <param name="enabled">True to apply the filter, that is block IR light. False to remove the filter, that is allow IR light to reach the image sensor. Null to automatically switch between on and off depending on the lighting conditions.</param>
		/// <returns></returns>
		public PtzCommandBuilder IrCutFilter(bool? enabled)
		{
			WithParameter(new OnOffAutoRequestParameter("ircutfilter", enabled));
			return this;
		}
		
		/// <summary>
		/// Control the backlight compensation.
		/// </summary>
		/// <param name="enabled"></param>
		/// <returns></returns>
		public PtzCommandBuilder BacklightCompensation(bool enabled)
		{
			WithParameter(new OnOffRequestParameter("backlight", enabled));
			return this;
		}
	}
}