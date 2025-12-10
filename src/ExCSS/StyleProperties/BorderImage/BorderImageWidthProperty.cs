namespace ExCSS
{
    using static Converters;

    internal sealed class BorderImageWidthProperty : Property
    {
        internal static readonly IValueConverter TheConverter = WithAny(
            ImageBorderWidthConverter.Option(1),
            ImageBorderWidthConverter.Option(),
            ImageBorderWidthConverter.Option(),
            ImageBorderWidthConverter.Option());

        private static readonly IValueConverter StyleConverter = TheConverter.OrDefault(1);

        internal BorderImageWidthProperty()
            : base(PropertyNames.BorderImageWidth)
        {
        }

        internal override IValueConverter Converter => StyleConverter;
    }
}