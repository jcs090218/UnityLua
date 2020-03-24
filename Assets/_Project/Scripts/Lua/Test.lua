-- ========================================================================
-- $File: Test.lua $
-- $Date: 2020-03-24 15:42:27 $
-- $Revision: $
-- $Creator: Jen-Chieh Shen $
-- $Notice: See LICENSE.txt for modification and distribution information
--                   Copyright © 2020 by Shen, Jen-Chieh $
-- ========================================================================

Test = {}
local this = Test

----------------------------------------------------------------
-- Use this for initialization.
----------------------------------------------------------------
function this.Start()
    print("Start function from `Test.lua` file!")
end

----------------------------------------------------------------
-- Update is called once per frame.
----------------------------------------------------------------
-- @param { MonoBehaviour } mb : MonoBehaviour component
-- represent as game object.
----------------------------------------------------------------
function this.Update(mb)
    -- Test input module in Lua.
    if Input.GetKeyDown(KeyCode.A) then
        print("Key pressed! from `Test.lua` file!")
    end
end
