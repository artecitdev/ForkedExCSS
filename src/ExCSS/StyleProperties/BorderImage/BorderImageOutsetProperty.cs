namespace ExCSS
{
    using static Converters;

    internal sealed class BorderImageOutsetProperty : Property
    {
        internal static readonly IValueConverter TheConverter = WithAny(
            ImageBorderOutsetConverter.Option(Length.Zero),
            ImageBorderOutsetConverter.Option(),
            ImageBorderOutsetConverter.Option(),
            ImageBorderOutsetConverter.Option());

        private static readonly IValueConverter StyleConverter = TheConverter.OrDefault(Length.Zero);

        internal BorderImageOutsetProperty()
            : base(PropertyNames.BorderImageOutset)
        {
        }

        internal override IValueConverter Converter => StyleConverter;
    }
}