
Public Class LabColor
    Public L As Double
    Public A As Double
    Public B As Double

    Public Shared Function FromColor(color As Color) As LabColor
        Dim r As Double = color.R / 255.0
        Dim g As Double = color.G / 255.0
        Dim b As Double = color.B / 255.0

        Dim x As Double = r * 0.4124564 + g * 0.3575761 + b * 0.1804375
        Dim y As Double = r * 0.2126729 + g * 0.7151522 + b * 0.072175
        Dim z As Double = r * 0.0193339 + g * 0.119192 + b * 0.9503041

        x /= 0.95047
        y /= 1.0
        z /= 1.08883

        x = If(x > 0.008856, Math.Pow(x, 1.0 / 3.0), (903.3 * x + 16.0) / 116.0)
        y = If(y > 0.008856, Math.Pow(y, 1.0 / 3.0), (903.3 * y + 16.0) / 116.0)
        z = If(z > 0.008856, Math.Pow(z, 1.0 / 3.0), (903.3 * z + 16.0) / 116.0)

        Dim lab As New LabColor()
        lab.L = Math.Max(0, 116.0 * y - 16.0)
        lab.A = 500.0 * (x - y)
        lab.B = 200.0 * (y - z)

        Return lab
    End Function

End Class