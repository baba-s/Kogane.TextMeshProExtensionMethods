# Kogane Text Mesh Pro Extension Methods

TMP_Text 型の拡張メソッドを管理するクラス

## 使用例

```cs
using Kogane;
using TMPro;
using UnityEngine;

public class Example : MonoBehaviour
{
    public TMP_Text m_tmpText;

    private void Awake()
    {
        // 値型をテキストとして設定できる
        m_tmpText.SetText( 'a' );
        m_tmpText.SetText( 1 );
        m_tmpText.SetText( 1u );
        
        // 値型をテキストとして設定できる
        // TMP_Text コンポーネントが null の場合は何もしない
        m_tmpText.SetTextIfNotNull( 'a' );
        m_tmpText.SetTextIfNotNull( 1 );
        m_tmpText.SetTextIfNotNull( 1u );
        
        // 書式指定文字列を使用してテキストを設定できる
        // ジェネリックを使用しているため GC Alloc を抑えられる
        m_tmpText.SetText( "{0}", Vector2.zero );
        m_tmpText.SetText( "{0},{1}", Vector2.zero, Vector2.one );

        // 独自の string.Format を指定できる
        TMP_TextExt.Formatter = new DefaultStringFormatter();
    }
}
```
