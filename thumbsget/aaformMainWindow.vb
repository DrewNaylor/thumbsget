'thumbsget - Gets the maxresdefault thumbnail for YouTube videos from
'original video URL. Not associated With YouTube or Google/Alphabet.
'Copyright (C) 2018 Drew Naylor
'YouTube and all related words are copyright
'and trademark Google/Alphabet. Also mentioned in About window.
'Google/Alphabet is not affiliated with either the thumbsget project or Drew Naylor
'and does not endorse this software.
'Any other companies mentioned own their respective copyrights/trademarks.
'(Note that the copyright years include the years left out by the hyphen.)
'
'This file is part of thumbsget.
'
'thumbsget is free software: you can redistribute it and/or modify
'it under the terms of the GNU General Public License as published by
'the Free Software Foundation, either version 3 of the License, or
'(at your option) any later version.
'
'thumbsget is distributed in the hope that it will be useful,
'but WITHOUT ANY WARRANTY; without even the implied warranty of
'MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
'GNU General Public License for more details.
'
'You should have received a copy of the GNU General Public License
'along with thumbsget.  If not, see <http://www.gnu.org/licenses/>.




Public Class aaformMainWindow
    Private Sub buttonGetThumbnailInBrowser_Click(sender As Object, e As EventArgs) Handles buttonGetThumbnailInBrowser.Click
        ' First, make sure the textbox isn't empty.
        If Not textboxVideoUrl.Text.Length = 0 Then
            ' Look at the URL, and replace "www.youtube.com/watch?v=" with "i.ytimg.com/vi/".
            ' Actually, first replace "www." with "" (nothing).
            Dim thumbnailUrl As String = textboxVideoUrl.Text
            Debug.WriteLine("Start:")
            Debug.WriteLine("Current URL: " & thumbnailUrl)
            ' Replace "www." with nothing.
            thumbnailUrl = thumbnailUrl.Replace("www.", "")
            Debug.WriteLine("Replace www. Current URL: " & thumbnailUrl)
            ' Replace "m." with nothing.
            thumbnailUrl = thumbnailUrl.Replace("m.", "")
            Debug.WriteLine("Replace m. Current URL: " & thumbnailUrl)
            ' Replace "?feature=youtu.be" with nothing.
            thumbnailUrl = thumbnailUrl.Replace("?feature=youtu.be", "")
            Debug.WriteLine("Replace ?feature=youtu.be. Current URL: " & thumbnailUrl)
            ' Replace "&feature=youtu.be" with nothing.
            thumbnailUrl = thumbnailUrl.Replace("&feature=youtu.be", "")
            Debug.WriteLine("Replace &feature=youtu.be. Current URL: " & thumbnailUrl)
            ' Now, if "youtube.com/watch?v=" is in the URL, replace it with "i.ytimg.com/vi/".
            If thumbnailUrl.Contains("youtube.com/watch?") Then
                thumbnailUrl = thumbnailUrl.Replace("youtube.com/watch?v=", "i.ytimg.com/vi/")
                Debug.WriteLine("Replace youtube.com/watch?v=. Current URL: " & thumbnailUrl)
            ElseIf thumbnailUrl.Contains("youtu.be/") Then
                ' If the URL contains "youtu.be/", replace that with "i.ytimg.com/vi/".
                thumbnailUrl = thumbnailUrl.Replace("youtu.be/", "i.ytimg.com/vi/")
                Debug.WriteLine("Replace youtu.be. Current URL: " & thumbnailUrl)
            End If
            ' Replace "watch" with nothing.
            thumbnailUrl = thumbnailUrl.Replace("watch", "")
            Debug.WriteLine("Replace watch. Current URL: " & thumbnailUrl)
            ' Replace "&v=" with nothing.
            thumbnailUrl = thumbnailUrl.Replace("&v=", "")
            Debug.WriteLine("Replace &v=. Current URL: " & thumbnailUrl)
            ' Once again, replace "youtube.com/" with "i.ytimg.com/vi/".
            thumbnailUrl = thumbnailUrl.Replace("youtube.com/", "i.ytimg.com/vi/")
            Debug.WriteLine("Replace youtube.com/. Current URL: " & thumbnailUrl)
        End If
    End Sub
End Class
